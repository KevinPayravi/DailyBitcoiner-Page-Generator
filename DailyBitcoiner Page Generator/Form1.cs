///////////////////////////////////////////////////////////////////////////////////////////
// Program: DailyBitcoiner Page Generator
// Author: Kevin Payravi (http://www.kevinpayravi.com/
// Description: This app produces HTML code for use on DailyBitcoiner.com.
// License: Fully copyrighted. No distribution without permission.
///////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DailyBitcoiner_Page_Generator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFacebook_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTwitter_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGooglePlus_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVimeo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxYouTube_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFlickr_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInstagram_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPinterest_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTumblr_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLinkedIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOther_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContactURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBitTrust_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxShipping_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCostRange_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelBitTrust_Click(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelHeaderSocialMedia_Click(object sender, EventArgs e)
        {

        }

        private void labelURL_Click(object sender, EventArgs e)
        {

        }

        private void labelCostRange_Click(object sender, EventArgs e)
        {

        }

        private void labelShipping_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////// HEADER //////////////////////////////////////

            string[] lines = { "<td style=\"width:2%;\">", 
            "</td>",
            "<td style=\"text-align:left; vertical-align:top; width:62%;\">",
            "	<h3>Bitcoin Merchant of the Day - " + textBoxDate.Text + "</h3>",
            "	<h1><a class=\"title\" href=\"" + textBoxURL.Text + "\">" + textBoxName.Text + "</a></h1>",
            };

            ////////////////////////////////////// HEADER INFO //////////////////////////////////////

            Boolean infoFirst = true;
            String info = null;

            if (textBoxShipping.Text != "")
            {
                info = "Shipping: " + textBoxShipping.Text;
                infoFirst = false;
            }

            if (textBoxCostRange.Text != "")
            {
                if (infoFirst == true)
                {
                    info = "Shipping: " + textBoxCostRange.Text;
                    infoFirst = false;
                }
                else
                {
                    info += "&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbspCost Range: " + textBoxCostRange.Text;
                }
            }

            if (textBoxBitTrust.Text != "")
            {
                if (infoFirst == true)
                {
                    info = "<a href=\"<a class=\"special\" href=\"" + textBoxBitTrust.Text + "\">BitTrust Reviews</a></h3>";
                    infoFirst = false;
                }
                else
                {
                    info += "&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp<a href=\"<a class=\"special\" href=\"" + textBoxBitTrust.Text + "\">BitTrust Reviews</a></h3>";
                }
            }

            string[] lines2 = { "	<h3>" + info + "</h3>",
            };

            ////////////////////////////////////// SOCIAL MEDIA //////////////////////////////////////

            Boolean socialMediaFirst = true;
            String socialMedia = null;

            if (textBoxFacebook.Text != "")
            {
                socialMedia = "<a class=\"special\" href=\"" + textBoxFacebook.Text + "\">Facebook</a>";
                socialMediaFirst = false;
            }

            if (textBoxTwitter.Text != "")
            {
                if (socialMediaFirst == true)
                {
                    socialMedia = "<a class=\"special\" href=\"" + textBoxTwitter.Text + "\">Twitter</a>";
                    socialMediaFirst = false;
                }
                else
                {
                    socialMedia += " - <a class=\"special\" href=\"" + textBoxTwitter.Text + "\">Twitter</a>";
                }
            }

            if (textBoxGooglePlus.Text != "")
            {
                if (socialMediaFirst == true)
                {
                    socialMedia = "<a class=\"special\" href=\"" + textBoxGooglePlus.Text + "\">G+</a>";
                    socialMediaFirst = false;
                }
                else
                {
                    socialMedia += " - <a class=\"special\" href=\"" + textBoxGooglePlus.Text + "\">G+</a>";
                }
            }

            if (textBoxLinkedIn.Text != "")
            {
                if (socialMediaFirst == true)
                {
                    socialMedia = "<a class=\"special\" href=\"" + textBoxLinkedIn.Text + "\">LinkedIn</a>";
                    socialMediaFirst = false;
                }
                else
                {
                    socialMedia += " - <a class=\"special\" href=\"" + textBoxLinkedIn.Text + "\">LinkedIn</a>";
                }
            }

            if (textBoxTumblr.Text != "")
            {
                if (socialMediaFirst == true)
                {
                    socialMedia = "<a class=\"special\" href=\"" + textBoxTumblr.Text + "\">Tumblr</a>";
                    socialMediaFirst = false;
                }
                else
                {
                    socialMedia += " - <a class=\"special\" href=\"" + textBoxTumblr.Text + "\">Tumblr</a>";
                }
            }

            if (textBoxPinterest.Text != "")
            {
                if (socialMediaFirst == true)
                {
                    socialMedia = "<a class=\"special\" href=\"" + textBoxPinterest.Text + "\">Pinterest</a>";
                    socialMediaFirst = false;
                }
                else
                {
                    socialMedia += " - <a class=\"special\" href=\"" + textBoxPinterest.Text + "\">Pinterest</a>";
                }
            }

            if (textBoxInstagram.Text != "")
            {
                if (socialMediaFirst == true)
                {
                    socialMedia = "<a class=\"special\" href=\"" + textBoxInstagram.Text + "\">Instagram</a>";
                    socialMediaFirst = false;
                }
                else
                {
                    socialMedia += " - <a class=\"special\" href=\"" + textBoxInstagram.Text + "\">Instagram</a>";
                }
            }

            if (textBoxFlickr.Text != "")
            {
                if (socialMediaFirst == true)
                {
                    socialMedia = "<a class=\"special\" href=\"" + textBoxFlickr.Text + "\">Flickr</a>";
                    socialMediaFirst = false;
                }
                else
                {
                    socialMedia += " - <a class=\"special\" href=\"" + textBoxFlickr.Text + "\">Flickr</a>";
                }
            }

            if (textBoxYouTube.Text != "")
            {
                if (socialMediaFirst == true)
                {
                    socialMedia = "<a class=\"special\" href=\"" + textBoxYouTube.Text + "\">YouTube</a>";
                    socialMediaFirst = false;
                }
                else
                {
                    socialMedia += " - <a class=\"special\" href=\"" + textBoxYouTube.Text + "\">YouTube</a>";
                }
            }

            if (textBoxVimeo.Text != "")
            {
                if (socialMediaFirst == true)
                {
                    socialMedia = "<a class=\"special\" href=\"" + textBoxVimeo.Text + "\">Vimeo</a>";
                    socialMediaFirst = false;
                }
                else
                {
                    socialMedia += " - <a class=\"special\" href=\"" + textBoxVimeo.Text + "\">Vimeo</a>";
                }
            }

            ////////////////////////////////////// DESCRIPTION //////////////////////////////////////

            string[] lines3 = { "	<h3>" + socialMedia + "</h3>",
            "	<h2>About</h2>",
            "	" + textBoxDescription.Text,
            "	<h2>Contact</h2>"
            };

            ////////////////////////////////////// CONTACT //////////////////////////////////////

            Boolean contactFirst = true;
            String contact = null;

            if (textBoxContactURL.Text != "")
            {
                contact = "<b>Online:</b> <a class=\"special\" href=\"" + textBoxContactURL.Text + "\">Support Page</a>";
                contactFirst = false;
            }

            if (textBoxAddress.Text != "")
            {
                if (contactFirst == true)
                {
                    contact = "	<b>Address:</b>" + textBoxAddress.Text;
                    contactFirst = false;
                }
                else
                {
                    contact += "\r\n	<br>";
                    contact += "\r\n	<b>Address:</b> " + textBoxAddress.Text;
                }
            }

            if (textBoxPhone.Text != "")
            {
                if (contactFirst == true)
                {
                    contact = "	<b>Phone:</b>" + textBoxPhone.Text;
                    contactFirst = false;
                }
                else
                {
                    contact += "\r\n	<br>";
                    contact += "\r\n	<b>Phone:</b> " + textBoxPhone.Text;
                }
            }

            ////////////////////////////////////// OTHER & HOMEPAGE IMAGE //////////////////////////////////////

            if (textBoxOther.Text != "")
            {
                string[] lines4 = {"	" + contact,
                "	" + textBoxOther.Text,
                "	<br>",
                "	<br>",
                "	<br>",
                "</td>",
                "<td style=\"width:2%; border-right:#F29320 2px solid;\">",
                "</td>",
                "<td style=\"text-align:center; vertical-align:top; width:34%;\">",
                "	<br>",
                "	<a href=\"" + textBoxURL.Text + "\"><img src=\"http://www.dailybitcoiner.com/Images/Listings/" + textBoxName.Text + "/Homepage.png\" alt=\"" + textBoxName.Text + "\" width=\"96%\"></a>",
                "	<h3><i>" + textBoxName.Text + "'s Homepage</i></h3>",
            };
            }
            else
            {
                string[] lines4 = {"	" + contact,
                "	<br>",
                "	<br>",
                "	<br>",
                "</td>",
                "<td style=\"width:2%; border-right:#F29320 2px solid;\">",
                "</td>",
                "<td style=\"text-align:center; vertical-align:top; width:34%;\">",
                "	<br>",
                "	<a href=\"" + textBoxURL.Text + "\"><img src=\"http://www.dailybitcoiner.com/Images/Listings/" + textBoxName.Text + "/Homepage.png\" alt=\"" + textBoxName.Text + "\" width=\"96%\"></a>",
                "	<h3><i>" + textBoxName.Text + "'s Homepage</i></h3>",
            };
            }

            ////////////////////////////////////// ALT. IMAGE & FINAL OUTPUT //////////////////////////////////////

            Boolean imageChecked = checkBoxImage.Checked;

            if (imageChecked)
            {
                string[] lines5 = {"	<br>",
                "	<a class=\"special\" href=\"" + textBoxImageDescription.Text +  "\"><img src=\"http://www.dailybitcoiner.com/Images/Listings/" + textBoxName.Text + "/Image1.jpg\" alt=\"" + textBoxName.Text + "\" width=\"65%\"></a>",
                "	<h3><i>" + textBoxImageDescription.Text + "</i></h3>",
                "</td>"
                };
                System.IO.File.WriteAllLines(@"C:\Users\Kayvan\Desktop\Output.txt", lines);
                System.IO.File.AppendAllLines(@"C:\Users\Kayvan\Desktop\Output.txt", lines2);
                System.IO.File.AppendAllLines(@"C:\Users\Kayvan\Desktop\Output.txt", lines3);
                System.IO.File.AppendAllLines(@"C:\Users\Kayvan\Desktop\Output.txt", lines4);
                System.IO.File.AppendAllLines(@"C:\Users\Kayvan\Desktop\Output.txt", lines5);
            }
            else
            {
                System.IO.File.WriteAllLines(@"C:\Users\Kayvan\Desktop\Output.txt", lines);
                System.IO.File.AppendAllLines(@"C:\Users\Kayvan\Desktop\Output.txt", lines2);
                System.IO.File.AppendAllLines(@"C:\Users\Kayvan\Desktop\Output.txt", lines3);
                System.IO.File.AppendAllLines(@"C:\Users\Kayvan\Desktop\Output.txt", lines4);
                System.IO.File.AppendAllText(@"C:\Users\Kayvan\Desktop\Output.txt", "\r\n</td>");
            }

        }

    }
}
