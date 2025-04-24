using System.Drawing;
using System.Drawing.Printing;
using ZXing;


namespace DosagePrinter
{
    public partial class Form1 : Form
    {
        private List<StickerInfo> stickers = new List<StickerInfo>();
        private TextBox txtInfo;


       



        public Form1()
        {
            InitializeComponent();
            InitializeEditableControls();
            //ValidateTextBoxInput();
        }




        private void btnAddSticker_Click(object sender, EventArgs e)
        {
            txtInfo.Invalidate();
            var sticker = new StickerInfo
            {
                Dosage = lstDosage.Text,
                Timing = lstTiming.Text,
                Duration = lstDuration.Text,
                Frequency = lstFrequency.Text,
                CustomText = txtInfo.Text // Include the custom text
            };

            if (string.IsNullOrWhiteSpace(sticker.CustomText))
            {
                sticker.CustomText = "للطلب عن طريق واتساب: 01157988704";
            }

            stickers.Add(sticker);
            listBoxStickers.Items.Add(sticker.CustomText);

            txtInfo.Text = string.Empty; // Clear the TextBox
            lstDosage.SelectedIndex = -1; // Remove selection
            lstTiming.SelectedIndex = -1;
            lstDuration.SelectedIndex = -1;
            lstFrequency.SelectedIndex = -1;
            panelStickerPreview.Invalidate();
        }

        private void panelStickerPreview_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White); // Clear background
            g.DrawRectangle(Pens.Transparent, 10, 70, 300, 120);
        }


        private void InitializeEditableControls()
        {
            txtInfo = new TextBox { 
                Location = new Point(30, 80),
                Width = 430, 
                Height = 60 
            };
            txtInfo.MaxLength = 70;

            panelStickerPreview.Controls.AddRange(new[] { txtInfo });

            lstDosage.SelectedIndexChanged += (s, e) => AppendToTextBox(lstDosage.Text);
            lstTiming.SelectedIndexChanged += (s, e) => AppendToTextBox(lstTiming.Text);
            lstDuration.SelectedIndexChanged += (s, e) => AppendToTextBox(lstDuration.Text);
            lstFrequency.SelectedIndexChanged += (s, e) => AppendToTextBox(lstFrequency.Text);
        }

        private void AppendToTextBox(string selectedText)
        {
            if (!string.IsNullOrWhiteSpace(selectedText))
            {
                // Check if adding the new text exceeds the MaxLength
                if (txtInfo.Text.Length + selectedText.Length <= txtInfo.MaxLength)
                {
                    if (!txtInfo.Text.Contains(selectedText)) // Prevent duplicates
                    {
                        txtInfo.Text = string.IsNullOrWhiteSpace(txtInfo.Text)
                            ? selectedText
                            : $"{txtInfo.Text} {selectedText}";
                    }
                }
                else
                {
                    MessageBox.Show("Maximum character limit reached!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //private void ValidateTextBoxInput()
        //{
        //    txtInfo.TextChanged += (s, e) =>
        //    {
        //        using (Graphics g = txtInfo.CreateGraphics())
        //        using (Font contentFont = new Font("Arial", 10, FontStyle.Bold))
        //        {
        //            StringFormat format = new StringFormat
        //            {
        //                FormatFlags = StringFormatFlags.LineLimit
        //            };

        //            float rectWidth = 140;
        //            float rectHeight = 50;

        //            // Check if text fits
        //            SizeF textSize = g.MeasureString(txtInfo.Text, contentFont, new SizeF(rectWidth, rectHeight), format);

        //            while (textSize.Height > rectHeight && txtInfo.Text.Length > 0)
        //            {
        //                txtInfo.Text = txtInfo.Text.Substring(0, txtInfo.Text.Length - 1);
        //                txtInfo.SelectionStart = txtInfo.Text.Length;
        //                textSize = g.MeasureString(txtInfo.Text, contentFont, new SizeF(rectWidth, rectHeight), format);
        //            }
        //        }
        //    };
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            // Wire up all combo boxes to the same change handler
            lstDosage.SelectedIndexChanged += ListBox_Changed;
            lstTiming.SelectedIndexChanged += ListBox_Changed;
            lstDuration.SelectedIndexChanged += ListBox_Changed;
            lstFrequency.SelectedIndexChanged += ListBox_Changed;


        }
        private void ListBox_Changed(object sender, EventArgs e)
        {
            panelStickerPreview.Invalidate();
        }




        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int numberOfStickers = (int)numericUpDown1.Value;
                if (numberOfStickers > 0)
                {
                    int quantity = (int)numericUpDown1.Value; // Get the quantity

                    for (int i = 0; i < quantity; i++)
                    {
                        var sticker = new StickerInfo
                        {
                            Dosage = lstDosage.Text,
                            Timing = lstTiming.Text,
                            Duration = lstDuration.Text,
                            Frequency = lstFrequency.Text,
                            CustomText = txtInfo.Text // Include the custom text
                        };

                        if (string.IsNullOrWhiteSpace(sticker.CustomText))
                        {
                            sticker.CustomText = "للطلب عن طريق واتساب: 01157988704";
                        }

                        stickers.Add(sticker);
                        listBoxStickers.Items.Add(sticker.CustomText);

                    }
                    numericUpDown1.Value = 1;
                    // Clear selections after adding
                    lstDosage.SelectedIndex = -1;
                    lstTiming.SelectedIndex = -1;
                    lstDuration.SelectedIndex = -1;
                    lstFrequency.SelectedIndex = -1;

                    panelStickerPreview.Invalidate();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if (listBoxStickers.SelectedIndex != -1)
            {
                // Remove from both the list and listbox
                stickers.RemoveAt(listBoxStickers.SelectedIndex);
                listBoxStickers.Items.RemoveAt(listBoxStickers.SelectedIndex);
                panelStickerPreview.Invalidate();
            }
            else
            {
                MessageBox.Show("Please select a sticker to remove", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear all stickers?",
                                                "Confirm Clear",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                stickers.Clear();
                listBoxStickers.Items.Clear();
                panelStickerPreview.Invalidate();
            }
        }


        //printing---------------------------------------------------------------------->


        private void DrawSticker(Graphics graphics, Rectangle marginBounds, StickerInfo sticker)
        {
            float yPos = marginBounds.Top;
            float centerX = marginBounds.Left + marginBounds.Width / 2f;
            centerX -=(int) numRightMargin.Value; // change  if needed


            // Draw logo
            if (pictureBoxLogo.Image != null)
            {
                int logoWidth = 145;
                int logoHeight = 40;
                float logoX = centerX - logoWidth / 2f; //center 

                graphics.DrawImage(pictureBoxLogo.Image, logoX, yPos, logoWidth, logoHeight);
                yPos += logoHeight +2; // move Y position down after image
            }

            float rectWidth = 140;
            float rectHeight = 50;
            float rectX = centerX - rectWidth / 2f;
            RectangleF rect = new RectangleF(rectX, yPos, rectWidth, rectHeight);

            graphics.DrawRectangle(Pens. Transparent, rect.X, rect.Y, rect.Width, rect.Height);


            using (Font contentFont = new Font("Arial", 10, FontStyle.Bold))
            {
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,     
                    LineAlignment = StringAlignment.Near,
                    FormatFlags = StringFormatFlags.LineLimit
                };

                    graphics.DrawString(sticker.CustomText, contentFont, Brushes.Black, rect, format);
                
            }
        }
        



        //one methode for both print and prevview
        private PrintDocument CreateStickerPrintDocument(StickerInfo sticker, string printerName = null)
        {
            PrintDocument printDocument = new PrintDocument();

            if (!string.IsNullOrEmpty(printerName))
                printDocument.PrinterSettings.PrinterName = printerName;

            int width = (int)numericUpDownW.Value;
            int height = (int)numericUpDownH.Value;

            printDocument.DefaultPageSettings.PaperSize = new PaperSize("CustomSticker", width, height);
            printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            printDocument.PrintPage += (sender, ev) =>
            {
                DrawSticker(ev.Graphics, ev.PageBounds, sticker);
            };

            return printDocument;
        }


        private void PrintStickerDirectly(StickerInfo sticker, string printerName)
        {
            var printDocument = CreateStickerPrintDocument(sticker, printerName);
            printDocument.Print();
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (stickers.Count == 0)
            {
                MessageBox.Show("No stickers to print.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PrintDialog printDialog = new PrintDialog();
            printDialog.PrinterSettings = new PrinterSettings();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPrinter = printDialog.PrinterSettings.PrinterName;

                try
                {
                    foreach (var sticker in stickers)
                    {
                        PrintStickerDirectly(sticker, selectedPrinter);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Printing failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ShowStickerPreview(StickerInfo sticker)
        {
            var printDocument = CreateStickerPrintDocument(sticker);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 400,
                Height = 200
            };

            previewDialog.ShowDialog();
        }


        private void prntPrevw_Click(object sender, EventArgs e)
        {
            if (listBoxStickers.SelectedIndex != -1)
            {
                var selectedSticker = stickers[listBoxStickers.SelectedIndex];
                ShowStickerPreview(selectedSticker);
            }
            else
            {
                MessageBox.Show("Please select a sticker to preview.");
            }
        }



        //adjust size for the Label onlyyyy
        private void numericUpDownH_ValueChanged(object sender, EventArgs e)
        {
            UpdateStickerSizeLabel();
        }

        private void numericUpDownW_ValueChanged(object sender, EventArgs e)
        {
            UpdateStickerSizeLabel();
        }

        private void UpdateStickerSizeLabel()
        {
            int width = (int)numericUpDownW.Value;
            int height = (int)numericUpDownH.Value;

            float widthMm = width / 3.937f;
            float heightMm = height / 3.937f;

            lblSize.Text = $"Sticker size: {widthMm:F1} mm × {heightMm:F1} mm";
        }




    }

}
