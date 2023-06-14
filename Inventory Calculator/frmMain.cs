using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Microsoft.Win32;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace Inventory_Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnGetProfile_Click(object sender, EventArgs e)
        {
            string steamId = txtID.Text.Trim();

            if (string.IsNullOrWhiteSpace(steamId))
            {
                MessageBox.Show("Please enter a valid Steam ID.", "Invalid Steam ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show the progress bar and set the style to Marquee
            prgLoading.Style = ProgressBarStyle.Marquee;
            prgLoading.Visible = true;

            // Create and start the timer
            marqueeTimer = new Timer();
            marqueeTimer.Interval = 25; // Adjust the interval to change the speed
            marqueeTimer.Tick += marqueeTimer_Tick;
            marqueeTimer.Start();

            await GetProfileAsync(steamId);

            // Stop the timer
            marqueeTimer.Stop();
            marqueeTimer.Dispose();

            // Hide the progress bar
            prgLoading.Visible = false;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string steamId = txtID.Text.Trim();

                if (string.IsNullOrWhiteSpace(steamId))
                {
                    MessageBox.Show("Please enter a valid Steam ID.", "Invalid Steam ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Show the progress bar and set the style to Marquee
                prgLoading.Style = ProgressBarStyle.Marquee;
                prgLoading.Visible = true;

                // Create and start the timer
                marqueeTimer = new Timer();
                marqueeTimer.Interval = 25; // Adjust the interval to change the speed
                marqueeTimer.Tick += marqueeTimer_Tick;
                marqueeTimer.Start();

                await GetProfileAsync(steamId);

                // Stop the timer
                marqueeTimer.Stop();
                marqueeTimer.Dispose();

                // Hide the progress bar
                prgLoading.Visible = false;
            }
        }

        private async Task GetProfileAsync(string steamId)
        {
            string url = $"https://csgobackpack.net/?nick={steamId}";

            HttpClient client = new HttpClient();
            string htmlContent = await client.GetStringAsync(url);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlContent);

            // Retrieve nickname
            HtmlNode nicknameNode = doc.DocumentNode.SelectSingleNode("//div[@class='media-body']/h3");
            string nickname = nicknameNode?.InnerText.Trim();

            if (!string.IsNullOrEmpty(nickname))
            {
                UpdateLabelText(lblNickname, nickname);
            }
            else
            {
                UpdateLabelText(lblNickname, "Nickname not found");
            }

            // Retrieve profile picture
            HtmlNode imgNode = doc.DocumentNode.SelectSingleNode($"//a[@href='http://steamcommunity.com/id/{steamId}']/img[@class='media-object img-rounded']");
            string imageUrl = null;

            if (imgNode != null)
            {
                imageUrl = imgNode.GetAttributeValue("src", "");
            }

            if (string.IsNullOrEmpty(imageUrl))
            {
                // Fall back to profiles URL
                HtmlNode profileLinkNode = doc.DocumentNode.SelectSingleNode($"//a[@href='http://steamcommunity.com/profiles/{steamId}']/img[@class='media-object img-rounded']");
                if (profileLinkNode != null)
                {
                    imageUrl = profileLinkNode.GetAttributeValue("src", "");
                }
            }

            if (!string.IsNullOrEmpty(imageUrl))
            {
                using (var imageClient = new HttpClient())
                {
                    var imageBytes = await imageClient.GetByteArrayAsync(imageUrl);
                    var imageStream = new MemoryStream(imageBytes);
                    UpdatePictureBoxImage(pbProfilePicture, Image.FromStream(imageStream));
                }
            }
            else
            {
                UpdatePictureBoxImage(pbProfilePicture, null);
            }

            // Check if the ID exists
            HtmlNode messageNode = doc.DocumentNode.SelectSingleNode("//div[@class='well']/h4[text()='There are no users that match your search']");
            if (messageNode != null)
            {
                UpdateLabelText(lblInventoryValue, "Invalid Steam ID");
                UpdateLabelText(lblItemsValue, "Invalid Steam ID");
                UpdateLabelText(lblValue1, "Invalid Steam ID");
                UpdateLabelText(lblValue2, "Invalid Steam ID");
                UpdateLabelText(lblValue3, "Invalid Steam ID");
                UpdateLabelText(lblValue4, "Invalid Steam ID");
                UpdateLabelText(lblValue5, "Invalid Steam ID");
                UpdateLabelText(lblSellValue, "Invalid Steam ID");
                UpdateLabelText(lblTitle1, "N/A");
                UpdateLabelText(lblTitle2, "N/A");
                UpdateLabelText(lblTitle3, "N/A");
                UpdateLabelText(lblTitle4, "N/A");
                UpdateLabelText(lblTitle5, "N/A");
                UpdatePictureBoxImage(pbProfilePicture, null);
                return;
            }

            // Check if the ID is private
            HtmlNode privateNode = doc.DocumentNode.SelectSingleNode("//div[@class='well']/h3/font[contains(text(), 'This inventory is private or user doesn')]");
            if (privateNode != null)
            {
                UpdateLabelText(lblInventoryValue, "This inventory is private or empty");
                UpdateLabelText(lblItemsValue, "This inventory is private or empty");
                UpdateLabelText(lblValue1, "This inventory is private or empty");
                UpdateLabelText(lblValue2, "This inventory is private or empty");
                UpdateLabelText(lblValue3, "This inventory is private or empty");
                UpdateLabelText(lblValue4, "This inventory is private or empty");
                UpdateLabelText(lblValue5, "This inventory is private or empty");
                UpdateLabelText(lblTitle1, "N/A");
                UpdateLabelText(lblTitle2, "N/A");
                UpdateLabelText(lblTitle3, "N/A");
                UpdateLabelText(lblTitle4, "N/A");
                UpdateLabelText(lblTitle5, "N/A");
                UpdateLabelText(lblSellValue, "This inventory is private or empty");

                return;
            }

            // Retrieve inventory value
            HtmlNode valueNode = doc.DocumentNode.SelectSingleNode("//p");
            if (valueNode != null)
            {
                string inventoryValueText = valueNode.InnerText.Trim();
                UpdateLabelText(lblInventoryValue, inventoryValueText);

                string[] currencySymbols = { "€", "$", "£", "zł", "P", "kr", "kr", "$", "R$", "E", "$", "kr", "¥", "¥", "₺" };
                string inventoryValueTextNoCurrency = inventoryValueText;
                foreach (string currencySymbol in currencySymbols)
                {
                    inventoryValueTextNoCurrency = inventoryValueTextNoCurrency.Replace(currencySymbol, "");
                }
                string inventoryValueTextNoEuro = inventoryValueTextNoCurrency.Trim();

                // Declare and initialize cultureInfo
                CultureInfo cultureInfo = CultureInfo.InvariantCulture;

                if (decimal.TryParse(inventoryValueTextNoEuro, NumberStyles.Number, cultureInfo, out decimal sellValue))
                {
                    decimal sellValuePercentage = Math.Floor(sellValue * 0.85m * 100) / 100;
                    string sellValueFormatted = sellValuePercentage.ToString("0.00", cultureInfo);

                    // Retrieve the currency symbol from inventoryValueText
                    string currencySymbol = GetCurrencySymbol(inventoryValueText);

                    // Append the currency symbol to the sell value
                    string sellValueWithCurrency = sellValueFormatted + " " + currencySymbol;

                    UpdateLabelText(lblSellValue, sellValueWithCurrency);
                }
                else
                {
                    UpdateLabelText(lblSellValue, "Unable to retrieve the sell value.");
                }

            }
            else
            {
                UpdateLabelText(lblInventoryValue, "Unable to retrieve the inventory value.");
                UpdateLabelText(lblSellValue, string.Empty);
            }

            // Retrieve other values
            HtmlNodeCollection valueNodes = doc.DocumentNode.SelectNodes("//h3/following-sibling::p");
            if (valueNodes != null && valueNodes.Count >= 6)
            {
                string itemsValueText = WebUtility.HtmlDecode(valueNodes[0].InnerText.Trim());
                string lblValue1Text = WebUtility.HtmlDecode(valueNodes[1].InnerText.Trim());
                string lblValue2Text = WebUtility.HtmlDecode(valueNodes[2].InnerText.Trim());
                string lblValue3Text = WebUtility.HtmlDecode(valueNodes[3].InnerText.Trim());
                string lblValue4Text = WebUtility.HtmlDecode(valueNodes[4].InnerText.Trim());
                string lblValue5Text = WebUtility.HtmlDecode(valueNodes[5].InnerText.Trim());

                UpdateLabelText(lblItemsValue, itemsValueText);
                UpdateLabelText(lblValue1, lblValue1Text);
                UpdateLabelText(lblValue2, lblValue2Text);
                UpdateLabelText(lblValue3, lblValue3Text);
                UpdateLabelText(lblValue4, lblValue4Text);
                UpdateLabelText(lblValue5, lblValue5Text);
            }
            else if (valueNodes != null && valueNodes.Count >= 5)
            {
                string itemsValueText = WebUtility.HtmlDecode(valueNodes[0].InnerText.Trim());
                string lblValue1Text = WebUtility.HtmlDecode(valueNodes[1].InnerText.Trim());
                string lblValue2Text = WebUtility.HtmlDecode(valueNodes[2].InnerText.Trim());
                string lblValue3Text = WebUtility.HtmlDecode(valueNodes[3].InnerText.Trim());
                string lblValue4Text = WebUtility.HtmlDecode(valueNodes[4].InnerText.Trim());

                UpdateLabelText(lblItemsValue, itemsValueText);
                UpdateLabelText(lblValue1, lblValue1Text);
                UpdateLabelText(lblValue2, lblValue2Text);
                UpdateLabelText(lblValue3, lblValue3Text);
                UpdateLabelText(lblValue4, lblValue4Text);
                UpdateLabelText(lblValue5, "N/A");
            }

            HtmlNode itemsHeadingNode = doc.DocumentNode.SelectSingleNode("//h3[contains(text(), 'Items')]");
            if (itemsHeadingNode != null)
            {
                HtmlNodeCollection titleNodes = itemsHeadingNode.SelectNodes("following-sibling::h3[position() <= 5]");

                if (titleNodes != null && titleNodes.Count >= 5)
                {
                    string lblTitle1Text = WebUtility.HtmlDecode(titleNodes[0].InnerText.Trim());
                    string lblTitle2Text = WebUtility.HtmlDecode(titleNodes[1].InnerText.Trim());
                    string lblTitle3Text = WebUtility.HtmlDecode(titleNodes[2].InnerText.Trim());
                    string lblTitle4Text = WebUtility.HtmlDecode(titleNodes[3].InnerText.Trim());
                    string lblTitle5Text = WebUtility.HtmlDecode(titleNodes[4].InnerText.Trim());

                    UpdateLabelText(lblTitle1, lblTitle1Text);
                    UpdateLabelText(lblTitle2, lblTitle2Text);
                    UpdateLabelText(lblTitle3, lblTitle3Text);
                    UpdateLabelText(lblTitle4, lblTitle4Text);
                    UpdateLabelText(lblTitle5, lblTitle5Text);
                }
                else if (titleNodes != null && titleNodes.Count >= 4)
                {
                    string lblTitle1Text = WebUtility.HtmlDecode(titleNodes[0].InnerText.Trim());
                    string lblTitle2Text = WebUtility.HtmlDecode(titleNodes[1].InnerText.Trim());
                    string lblTitle3Text = WebUtility.HtmlDecode(titleNodes[2].InnerText.Trim());
                    string lblTitle4Text = WebUtility.HtmlDecode(titleNodes[3].InnerText.Trim());

                    UpdateLabelText(lblTitle1, lblTitle1Text);
                    UpdateLabelText(lblTitle2, lblTitle2Text);
                    UpdateLabelText(lblTitle3, lblTitle3Text);
                    UpdateLabelText(lblTitle4, lblTitle4Text);
                    lblTitle5.Text = "N/A";
                }
            }
        }

        private void UpdateLabelText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() => label.Text = text));
            }
            else
            {
                label.Text = text;
            }
        }

        private void UpdatePictureBoxImage(PictureBox pictureBox, Image image)
        {
            if (pictureBox.InvokeRequired)
            {
                pictureBox.Invoke(new Action(() => pictureBox.Image = image));
            }
            else
            {
                pictureBox.Image = image;
            }
        }

        private string GetCurrencySymbol(string text)
        {
            string[] currencySymbols = new string[] { "$", "€", "£", "zł", "P", "kr", "kr", "R$", "E", "C$", "₺", "¥", "¥", "₺" };

            foreach (string currencySymbol in currencySymbols)
            {
                if (text.Contains(currencySymbol))
                {
                    return currencySymbol;
                }
            }

            return string.Empty;
        }

        private void marqueeTimer_Tick(object sender, EventArgs e)
        {
            // Force the progress bar to redraw
            prgLoading.Refresh();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfo frm = new frmInfo();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
