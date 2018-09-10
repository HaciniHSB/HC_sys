using Dapper;
using HC_Sender.Models;
using HCSys.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace HC_Sender
{
    public partial class Main : MaterialForm
    {

        //private readonly int arLanguage = 1;
        //private readonly int enLanguage = 2;
        //private readonly int urLanguage = 3;

        int BtnPitch = 50;

        int FTimerIndex = 1;
        int FSelectedLanguage = 0;

        public readonly string[] Ftxt_DestinationQuery =
                { "وجهة الطلب",
                  "Request destination",
                  "درخواست کی منزل" };

        public readonly string[] Ftxt_Query = 
                { "اختر الطلب",
                  "Choose a request",
                  "ایک درخواست منتخب کریں" };

        public readonly string[] Ftxt_Confirmation =
                { "هل تريد حقًا إرسال طلبك؟",
                  "Do you really want to send your request ?",
                  "کیا آپ واقعی اپنی درخواست بھیجنے کے لئے چاہتے ہیں؟" };

        public readonly string[] Ftxt_Thanks =
                {"شكرا على المساعدة"
                +"\n"+"سنرسل لك فريقًا في أسرع وقت ممكن",

                 "Thank you for help"
                +"\n"+"We are sending a team as soon as possible",

                 "مدد کے لیئے شکریہ"
                +"\n"+"ہم آپ کو کسی بھی ٹیم کو جلد از جلد بھیجیں"};

        public readonly string[] FHealthLabel =
                {"الخدمات الطبية",
                 "Medical assistance",
                 "طبی امداد"};

        public readonly string[] FFoodLabel =
                {"خدمة الطعام",
                 "Food service",
                 "کھانے کی خدمت"};

        public readonly string[] FCleaningLabel =
                {"الخدمات الصحية والتنظيف",
                 "Sanitary and cleaning services",
                 "سینیٹری کی خدمات اور صفائی"};

        public readonly string[] FMaintenanceLabel =
                {"خدمات الصيانة",
                 "Maintenance service",
                 "بحالی کی خدمات"};

        public readonly string[] FHelpMsg =
                {"أخي الحاج ، هل تحتاج إلى مساعدة؟"
                +"\n"+"انقر الشاشة",
                 "Do you need help?"
                 +"\n"+"Touche the screen",
                 "میرا بھائی حج، کیا آپ کی مدد کی ضرورت ہے؟"
                 +"\n"+"اسکرین پر کلک کریں"};

        private terminal_request FRequest;




        public Main()
        {
            InitializeComponent();
            Connexion.ConnectToDb();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                            Primary.BlueGrey900,
                                            Primary.BlueGrey500,
                                            Accent.LightBlue200,
                                            TextShade.WHITE);

            CenterControl(new Control[] { btArabic, btEnglish, btUrdu,
                                          lblArabic, lblEnglish, lblUrdu,
                                          btSend, btCancel,
                                          btHealth, btFood,
                                          btMaintenance, btCleaning,
                                          lblHealth, lblFood,
                                          lblMaintenance, lblCleaning});

            var FCenterPoint = (ClientSize.Width) / 2;

            btHealth.Left = FCenterPoint - 500;
            lblHealth.Left = btHealth.Left;

            btFood.Left = FCenterPoint - 225;
            lblFood.Left = btFood.Left;

            btMaintenance.Left = FCenterPoint + 225 -(200);
            lblMaintenance.Left = btMaintenance.Left;

            btCleaning.Left = FCenterPoint + 500 -(200);
            lblCleaning.Left = btCleaning.Left;

            tnxTimer.Enabled = true;
            msgTimer.Enabled = true;

            //lblMessage.Text = Terminal.RefreshTerminalMsg();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void cxtimer_Tick(object sender, EventArgs e)
        {
            //int i = int.Parse(System.Console.ReadLine());
            switch (FTimerIndex)
            {

                case 1:
                    {
                        lblSelectLanguage.Text = "اختر لغتك";
                        lblMessage.Text = FHelpMsg[FTimerIndex-1];
                        FTimerIndex = FTimerIndex + 1;
                        break;
                    }

                case 2:
                    {
                        lblSelectLanguage.Text = "Select your language";
                        lblMessage.Text = FHelpMsg[FTimerIndex-1];
                        FTimerIndex = FTimerIndex + 1;
                        break;
                    }

                case 3:
                    {
                        lblSelectLanguage.Text = "اپنی زبان منتخب کریں";
                        lblMessage.Text = FHelpMsg[FTimerIndex-1];
                        FTimerIndex = FTimerIndex + 1;
                        break;
                    }
                default:
                    {
                        FTimerIndex = 1;
                        break;

                    }
            }


        }

        private static void CenterControl(Control[] FControl)
        {
            foreach (var AItem in FControl)
            {
                AItem.Anchor = AnchorStyles.None;
            }
        }

        private void btArabic_Click(object sender, EventArgs e)
        {
            FSelectedLanguage = int.Parse(((PictureBox)sender).Tag.ToString());
            reWriteAllMessages();
            GoToNextTab();

            //Button FBtn;
            //int FOldTop = 100;
            //FreeButtons(tbQueryType);

            //var FData = Request_type.RefreshDataListe();
            //for (int i = 0; i < FData.Count; i++)
            //{
            //    switch (FSelectedLanguage)
            //    {
            //        case 1:
            //            {
            //                FBtn = CreateButton(tbQueryType, FData[i].Desciption_Ar, FData[i].Id, FOldTop + BtnPitch);
            //                break;
            //            }
            //        case 2:
            //            {
            //                FBtn = CreateButton(tbQueryType, FData[i].Description_En, FData[i].Id, FOldTop + BtnPitch);
            //                break;
            //            }
            //        case 3:
            //            {
            //                FBtn = CreateButton(tbQueryType, FData[i].Description_Urdo, FData[i].Id, FOldTop + BtnPitch);
            //                break;
            //            }
            //        default:
            //            {
            //                FBtn = CreateButton(tbQueryType, FData[i].Description_En, FData[i].Id, FOldTop + BtnPitch);
            //                break;
            //            }
            //    }

            //    FOldTop = FBtn.Top;
            //    FBtn.Click += (s, j) =>
            //    {
            //        GoToNextTab();

            //        Button FjBtn;
            //        int FjOldTop = 100;
            //        FreeButtons(tbQuery);

            //        var _tag = ((Button)s).Tag;


            //        var FjData = Request.RefreshDataListe(Int32.Parse(_tag.ToString()));
            //        for (int jj = 0; jj < FjData.Count; jj++)
            //        {
            //            switch (FSelectedLanguage)
            //            {
            //                case 1:
            //                    {
            //                        FjBtn = CreateButton(tbQuery, FjData[jj].Desciption_Ar, FjData[jj].Id , FjOldTop + BtnPitch);
            //                        break;
            //                    }
            //                case 2:
            //                    {
            //                        FjBtn = CreateButton(tbQuery, FjData[jj].Description_En, FjData[jj].Id, FjOldTop + BtnPitch);
            //                        break;
            //                    }
            //                case 3:
            //                    {
            //                        FjBtn = CreateButton(tbQuery, FjData[jj].Description_Urdo, FjData[jj].Id, FjOldTop + BtnPitch);
            //                        break;
            //                    }

            //                default:
            //                    {
            //                        FjBtn = CreateButton(tbQuery, FjData[jj].Description_En, FjData[jj].Id, FjOldTop + BtnPitch);
            //                        break;
            //                    }
            //            }
            //            FjOldTop = FjBtn.Top;
            //            FjBtn.Click += (z, k) =>
            //            {
            //                GoToNextTab();
            //            };

            //        }
            //    };
            //}
        }


        private void GoToNextTab()
        {
            PageTimer.Enabled = false;

            int FCurrentFocusedTab = mainTabControl.SelectedIndex;
            if ((mainTabControl.TabCount-1) == FCurrentFocusedTab)
            {
                GoToScreenSaver();
            }
            else
            {
                mainTabControl.SelectTab(FCurrentFocusedTab + 1);
                PageTimer.Enabled = true;
            }
        }

        private void GoToLastTab()
        {
            PageTimer.Enabled = false;

            int FCurrentFocusedTab = mainTabControl.SelectedIndex;
            mainTabControl.SelectTab(FCurrentFocusedTab - 1);
            PageTimer.Enabled = true;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            FRequest.DateTime = Connexion.GetServerDateTime();
            Connexion.NInsert(FRequest);

            GoToNextTab();
            GoToNextTab();
            Thread.Sleep(5000);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            GoToNextTab();
        }

        private void reWriteAllMessages()
        {
            lblDestinationQuery.Text = Ftxt_DestinationQuery[FSelectedLanguage-1];
            lblQuerySelection.Text = Ftxt_Query[FSelectedLanguage-1];
            lblConfirmation.Text = Ftxt_Confirmation[FSelectedLanguage-1];
            lblThanks.Text = Ftxt_Thanks[FSelectedLanguage - 1];

            lblHealth.Text = FHealthLabel[FSelectedLanguage - 1];
            lblFood.Text = FFoodLabel[FSelectedLanguage - 1];
            lblMaintenance.Text = FMaintenanceLabel[FSelectedLanguage - 1];
            lblCleaning.Text = FCleaningLabel[FSelectedLanguage - 1];

        }

        private void PageTimer_Tick(object sender, EventArgs e)
        {
            GoToScreenSaver();
        }

        private void GoToScreenSaver()
        {
            mainTabControl.SelectTab(0);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            GoToScreenSaver();
        }

        private void Main_Shown(object sender, EventArgs e)
        {

        }

        private void FreeButtons(TabPage APage)
        {
            var FBtns = Commons.GetAllComponents(APage, typeof(Button)).ToList();

            for (int i = 0; i < FBtns.Count(); i++)
            {
                FBtns[i].Dispose();
            }
        }


        private Button CreateButton(TabPage APage, string AText,int ATag, int ATop)
        {

            var button = new Button(); //MaterialRaisedButton();
            button.AutoSize = false;
            button.Top = ATop;
            button.Font = new Font(button.Font.Name, 18F);
            button.Text = AText;
            button.Height = 40;
            button.Tag = ATag;
            APage.Controls.Add(button);
            button.Width = 300;
            button.Left = (this.ClientSize.Width - button.Width) / 2;
            return button;

        }

        private void btBack2_Click(object sender, EventArgs e)
        {
            GoToLastTab();
        }

        private void msgTimer_Tick(object sender, EventArgs e)
        {
            //lblMessage.Text = Terminal.RefreshTerminalMsg();
        }

        private void btHealth_Click(object sender, EventArgs e)
        {
            GoToNextTab();




            Button FjBtn;
            int FjOldTop = 100;
            FreeButtons(tbQuery);

            var _tag = ((PictureBox)sender).Tag;

            var FjData = Request.RefreshDataListe(Int32.Parse(_tag.ToString()));
            for (int jj = 0; jj < FjData.Count; jj++)
            {
                switch (FSelectedLanguage)
                {
                    case 1:
                        {
                            FjBtn = CreateButton(tbQuery, FjData[jj].Desciption_Ar, FjData[jj].Id, FjOldTop + BtnPitch);
                            break;
                        }
                    case 2:
                        {
                            FjBtn = CreateButton(tbQuery, FjData[jj].Description_En, FjData[jj].Id, FjOldTop + BtnPitch);
                            break;
                        }
                    case 3:
                        {
                            FjBtn = CreateButton(tbQuery, FjData[jj].Description_Urdo, FjData[jj].Id, FjOldTop + BtnPitch);
                            break;
                        }

                    default:
                        {
                            FjBtn = CreateButton(tbQuery, FjData[jj].Description_En, FjData[jj].Id, FjOldTop + BtnPitch);
                            break;
                        }
                }
                FjOldTop = FjBtn.Top;
                FjBtn.Click += (z, k) =>
                {
                    GoToNextTab();

                    var _Ftag = int.Parse(((Button)z).Tag.ToString());
                    FRequest = new terminal_request();

                    FRequest.Request_Id = _Ftag;

                    var Rn = new Random();
                    int rInt = Rn.Next(0, 35);

                    var SQ = "SELECT * FROM terminal WHERE Id=@Id;";
                    var FReq = Connexion.db.QueryFirstOrDefault<Terminal>(SQ, new { Id = rInt });

                    FRequest.TerminalId = FReq.Id;
                    FRequest.Latitude = FReq.Latitude;
                    FRequest.Longitude = FReq.Longitude;
                };

            }
        }
    }


}
