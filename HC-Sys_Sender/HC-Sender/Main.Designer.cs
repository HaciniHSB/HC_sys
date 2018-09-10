namespace HC_Sender
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tbMsg = new System.Windows.Forms.TabPage();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tbLanguageSelection = new System.Windows.Forms.TabPage();
            this.lblUrdu = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblArabic = new System.Windows.Forms.Label();
            this.lblSelectLanguage = new System.Windows.Forms.Label();
            this.btUrdu = new System.Windows.Forms.PictureBox();
            this.btEnglish = new System.Windows.Forms.PictureBox();
            this.btArabic = new System.Windows.Forms.PictureBox();
            this.tbQueryType = new System.Windows.Forms.TabPage();
            this.lblCleaning = new System.Windows.Forms.Label();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btCleaning = new System.Windows.Forms.PictureBox();
            this.btMaintenance = new System.Windows.Forms.PictureBox();
            this.btFood = new System.Windows.Forms.PictureBox();
            this.btHealth = new System.Windows.Forms.PictureBox();
            this.btBack = new System.Windows.Forms.PictureBox();
            this.lblDestinationQuery = new System.Windows.Forms.Label();
            this.tbQuery = new System.Windows.Forms.TabPage();
            this.btBack1 = new System.Windows.Forms.PictureBox();
            this.lblQuerySelection = new System.Windows.Forms.Label();
            this.tbConfirmation = new System.Windows.Forms.TabPage();
            this.btCancel = new System.Windows.Forms.PictureBox();
            this.btSend = new System.Windows.Forms.PictureBox();
            this.btBack2 = new System.Windows.Forms.PictureBox();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.tbThanksMsg = new System.Windows.Forms.TabPage();
            this.lblThanks = new System.Windows.Forms.Label();
            this.tnxTimer = new System.Windows.Forms.Timer(this.components);
            this.PageTimer = new System.Windows.Forms.Timer(this.components);
            this.msgTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTabControl.SuspendLayout();
            this.tbMsg.SuspendLayout();
            this.tbLanguageSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btUrdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btArabic)).BeginInit();
            this.tbQueryType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCleaning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBack)).BeginInit();
            this.tbQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btBack1)).BeginInit();
            this.tbConfirmation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBack2)).BeginInit();
            this.tbThanksMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTabSelector1.BaseTabControl = this.mainTabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Enabled = false;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 60);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 43);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "text to edit";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tbMsg);
            this.mainTabControl.Controls.Add(this.tbLanguageSelection);
            this.mainTabControl.Controls.Add(this.tbQueryType);
            this.mainTabControl.Controls.Add(this.tbQuery);
            this.mainTabControl.Controls.Add(this.tbConfirmation);
            this.mainTabControl.Controls.Add(this.tbThanksMsg);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 103);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(800, 497);
            this.mainTabControl.TabIndex = 1;
            // 
            // tbMsg
            // 
            this.tbMsg.Controls.Add(this.lblMessage);
            this.tbMsg.Location = new System.Drawing.Point(4, 22);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Padding = new System.Windows.Forms.Padding(50);
            this.tbMsg.Size = new System.Drawing.Size(792, 471);
            this.tbMsg.TabIndex = 5;
            this.tbMsg.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(50, 50);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(692, 371);
            this.lblMessage.TabIndex = 18;
            this.lblMessage.Text = "Need some help ?";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbLanguageSelection
            // 
            this.tbLanguageSelection.Controls.Add(this.lblUrdu);
            this.tbLanguageSelection.Controls.Add(this.lblEnglish);
            this.tbLanguageSelection.Controls.Add(this.lblArabic);
            this.tbLanguageSelection.Controls.Add(this.lblSelectLanguage);
            this.tbLanguageSelection.Controls.Add(this.btUrdu);
            this.tbLanguageSelection.Controls.Add(this.btEnglish);
            this.tbLanguageSelection.Controls.Add(this.btArabic);
            this.tbLanguageSelection.Location = new System.Drawing.Point(4, 22);
            this.tbLanguageSelection.Name = "tbLanguageSelection";
            this.tbLanguageSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tbLanguageSelection.Size = new System.Drawing.Size(792, 471);
            this.tbLanguageSelection.TabIndex = 0;
            this.tbLanguageSelection.Text = "Language selection";
            this.tbLanguageSelection.UseVisualStyleBackColor = true;
            // 
            // lblUrdu
            // 
            this.lblUrdu.AutoSize = true;
            this.lblUrdu.Font = new System.Drawing.Font("Roboto", 36F);
            this.lblUrdu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUrdu.Location = new System.Drawing.Point(604, 308);
            this.lblUrdu.Name = "lblUrdu";
            this.lblUrdu.Size = new System.Drawing.Size(95, 58);
            this.lblUrdu.TabIndex = 20;
            this.lblUrdu.Text = "اردو";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Roboto", 36F);
            this.lblEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEnglish.Location = new System.Drawing.Point(323, 308);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(181, 58);
            this.lblEnglish.TabIndex = 19;
            this.lblEnglish.Text = "English";
            // 
            // lblArabic
            // 
            this.lblArabic.AutoSize = true;
            this.lblArabic.Font = new System.Drawing.Font("Roboto", 36F);
            this.lblArabic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblArabic.Location = new System.Drawing.Point(127, 308);
            this.lblArabic.Name = "lblArabic";
            this.lblArabic.Size = new System.Drawing.Size(116, 58);
            this.lblArabic.TabIndex = 18;
            this.lblArabic.Text = "عربية";
            // 
            // lblSelectLanguage
            // 
            this.lblSelectLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelectLanguage.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSelectLanguage.Location = new System.Drawing.Point(3, 3);
            this.lblSelectLanguage.Name = "lblSelectLanguage";
            this.lblSelectLanguage.Size = new System.Drawing.Size(786, 92);
            this.lblSelectLanguage.TabIndex = 17;
            this.lblSelectLanguage.Text = "Select your language";
            this.lblSelectLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btUrdu
            // 
            this.btUrdu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUrdu.Image = ((System.Drawing.Image)(resources.GetObject("btUrdu.Image")));
            this.btUrdu.Location = new System.Drawing.Point(547, 105);
            this.btUrdu.Name = "btUrdu";
            this.btUrdu.Size = new System.Drawing.Size(200, 200);
            this.btUrdu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btUrdu.TabIndex = 4;
            this.btUrdu.TabStop = false;
            this.btUrdu.Tag = "3";
            this.btUrdu.Click += new System.EventHandler(this.btArabic_Click);
            // 
            // btEnglish
            // 
            this.btEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnglish.Image = ((System.Drawing.Image)(resources.GetObject("btEnglish.Image")));
            this.btEnglish.Location = new System.Drawing.Point(312, 105);
            this.btEnglish.Name = "btEnglish";
            this.btEnglish.Size = new System.Drawing.Size(200, 200);
            this.btEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btEnglish.TabIndex = 3;
            this.btEnglish.TabStop = false;
            this.btEnglish.Tag = "2";
            this.btEnglish.Click += new System.EventHandler(this.btArabic_Click);
            // 
            // btArabic
            // 
            this.btArabic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btArabic.Image = ((System.Drawing.Image)(resources.GetObject("btArabic.Image")));
            this.btArabic.Location = new System.Drawing.Point(80, 105);
            this.btArabic.Name = "btArabic";
            this.btArabic.Size = new System.Drawing.Size(200, 200);
            this.btArabic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btArabic.TabIndex = 2;
            this.btArabic.TabStop = false;
            this.btArabic.Tag = "1";
            this.btArabic.Click += new System.EventHandler(this.btArabic_Click);
            // 
            // tbQueryType
            // 
            this.tbQueryType.Controls.Add(this.lblCleaning);
            this.tbQueryType.Controls.Add(this.lblMaintenance);
            this.tbQueryType.Controls.Add(this.lblFood);
            this.tbQueryType.Controls.Add(this.lblHealth);
            this.tbQueryType.Controls.Add(this.btCleaning);
            this.tbQueryType.Controls.Add(this.btMaintenance);
            this.tbQueryType.Controls.Add(this.btFood);
            this.tbQueryType.Controls.Add(this.btHealth);
            this.tbQueryType.Controls.Add(this.btBack);
            this.tbQueryType.Controls.Add(this.lblDestinationQuery);
            this.tbQueryType.Location = new System.Drawing.Point(4, 22);
            this.tbQueryType.Name = "tbQueryType";
            this.tbQueryType.Padding = new System.Windows.Forms.Padding(3);
            this.tbQueryType.Size = new System.Drawing.Size(792, 471);
            this.tbQueryType.TabIndex = 1;
            this.tbQueryType.Text = "Query type";
            this.tbQueryType.UseVisualStyleBackColor = true;
            // 
            // lblCleaning
            // 
            this.lblCleaning.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleaning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCleaning.Location = new System.Drawing.Point(701, 314);
            this.lblCleaning.Name = "lblCleaning";
            this.lblCleaning.Size = new System.Drawing.Size(199, 100);
            this.lblCleaning.TabIndex = 28;
            this.lblCleaning.Text = "عربية";
            this.lblCleaning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMaintenance.Location = new System.Drawing.Point(480, 314);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(199, 100);
            this.lblMaintenance.TabIndex = 27;
            this.lblMaintenance.Text = "عربية";
            this.lblMaintenance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFood
            // 
            this.lblFood.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFood.Location = new System.Drawing.Point(260, 314);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(199, 100);
            this.lblFood.TabIndex = 26;
            this.lblFood.Text = "عربية";
            this.lblFood.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHealth
            // 
            this.lblHealth.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHealth.Location = new System.Drawing.Point(35, 314);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(199, 100);
            this.lblHealth.TabIndex = 25;
            this.lblHealth.Text = "عربية";
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btCleaning
            // 
            this.btCleaning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCleaning.Image = ((System.Drawing.Image)(resources.GetObject("btCleaning.Image")));
            this.btCleaning.Location = new System.Drawing.Point(700, 111);
            this.btCleaning.Name = "btCleaning";
            this.btCleaning.Size = new System.Drawing.Size(200, 200);
            this.btCleaning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btCleaning.TabIndex = 24;
            this.btCleaning.TabStop = false;
            this.btCleaning.Tag = "2";
            this.btCleaning.Click += new System.EventHandler(this.btHealth_Click);
            // 
            // btMaintenance
            // 
            this.btMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btMaintenance.Image")));
            this.btMaintenance.Location = new System.Drawing.Point(479, 111);
            this.btMaintenance.Name = "btMaintenance";
            this.btMaintenance.Size = new System.Drawing.Size(200, 200);
            this.btMaintenance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btMaintenance.TabIndex = 23;
            this.btMaintenance.TabStop = false;
            this.btMaintenance.Tag = "3";
            this.btMaintenance.Click += new System.EventHandler(this.btHealth_Click);
            // 
            // btFood
            // 
            this.btFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFood.Image = ((System.Drawing.Image)(resources.GetObject("btFood.Image")));
            this.btFood.Location = new System.Drawing.Point(259, 111);
            this.btFood.Name = "btFood";
            this.btFood.Size = new System.Drawing.Size(200, 200);
            this.btFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btFood.TabIndex = 22;
            this.btFood.TabStop = false;
            this.btFood.Tag = "4";
            this.btFood.Click += new System.EventHandler(this.btHealth_Click);
            // 
            // btHealth
            // 
            this.btHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHealth.Image = ((System.Drawing.Image)(resources.GetObject("btHealth.Image")));
            this.btHealth.Location = new System.Drawing.Point(34, 111);
            this.btHealth.Name = "btHealth";
            this.btHealth.Size = new System.Drawing.Size(200, 200);
            this.btHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btHealth.TabIndex = 21;
            this.btHealth.TabStop = false;
            this.btHealth.Tag = "1";
            this.btHealth.Click += new System.EventHandler(this.btHealth_Click);
            // 
            // btBack
            // 
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.Location = new System.Drawing.Point(34, 31);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(64, 64);
            this.btBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btBack.TabIndex = 20;
            this.btBack.TabStop = false;
            this.btBack.Tag = "2";
            this.btBack.Click += new System.EventHandler(this.btBack2_Click);
            // 
            // lblDestinationQuery
            // 
            this.lblDestinationQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDestinationQuery.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDestinationQuery.Location = new System.Drawing.Point(3, 3);
            this.lblDestinationQuery.Name = "lblDestinationQuery";
            this.lblDestinationQuery.Size = new System.Drawing.Size(786, 92);
            this.lblDestinationQuery.TabIndex = 18;
            this.lblDestinationQuery.Text = "Destination of query";
            this.lblDestinationQuery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbQuery
            // 
            this.tbQuery.Controls.Add(this.btBack1);
            this.tbQuery.Controls.Add(this.lblQuerySelection);
            this.tbQuery.Location = new System.Drawing.Point(4, 22);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tbQuery.Size = new System.Drawing.Size(792, 471);
            this.tbQuery.TabIndex = 2;
            this.tbQuery.Text = "Query";
            this.tbQuery.UseVisualStyleBackColor = true;
            // 
            // btBack1
            // 
            this.btBack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack1.Image = ((System.Drawing.Image)(resources.GetObject("btBack1.Image")));
            this.btBack1.Location = new System.Drawing.Point(34, 31);
            this.btBack1.Name = "btBack1";
            this.btBack1.Size = new System.Drawing.Size(64, 64);
            this.btBack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btBack1.TabIndex = 21;
            this.btBack1.TabStop = false;
            this.btBack1.Tag = "2";
            this.btBack1.Click += new System.EventHandler(this.btBack2_Click);
            // 
            // lblQuerySelection
            // 
            this.lblQuerySelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuerySelection.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuerySelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQuerySelection.Location = new System.Drawing.Point(3, 3);
            this.lblQuerySelection.Name = "lblQuerySelection";
            this.lblQuerySelection.Size = new System.Drawing.Size(786, 92);
            this.lblQuerySelection.TabIndex = 19;
            this.lblQuerySelection.Text = "Select a query";
            this.lblQuerySelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbConfirmation
            // 
            this.tbConfirmation.Controls.Add(this.btCancel);
            this.tbConfirmation.Controls.Add(this.btSend);
            this.tbConfirmation.Controls.Add(this.btBack2);
            this.tbConfirmation.Controls.Add(this.lblConfirmation);
            this.tbConfirmation.Location = new System.Drawing.Point(4, 22);
            this.tbConfirmation.Name = "tbConfirmation";
            this.tbConfirmation.Padding = new System.Windows.Forms.Padding(3);
            this.tbConfirmation.Size = new System.Drawing.Size(792, 471);
            this.tbConfirmation.TabIndex = 3;
            this.tbConfirmation.Text = "Confirmation";
            this.tbConfirmation.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(455, 182);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(128, 128);
            this.btCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btCancel.TabIndex = 23;
            this.btCancel.TabStop = false;
            this.btCancel.Tag = "2";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSend
            // 
            this.btSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSend.Image = ((System.Drawing.Image)(resources.GetObject("btSend.Image")));
            this.btSend.Location = new System.Drawing.Point(244, 182);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(128, 128);
            this.btSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btSend.TabIndex = 22;
            this.btSend.TabStop = false;
            this.btSend.Tag = "2";
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btBack2
            // 
            this.btBack2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack2.Image = ((System.Drawing.Image)(resources.GetObject("btBack2.Image")));
            this.btBack2.Location = new System.Drawing.Point(34, 31);
            this.btBack2.Name = "btBack2";
            this.btBack2.Size = new System.Drawing.Size(64, 64);
            this.btBack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btBack2.TabIndex = 21;
            this.btBack2.TabStop = false;
            this.btBack2.Tag = "2";
            this.btBack2.Click += new System.EventHandler(this.btBack2_Click);
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConfirmation.Font = new System.Drawing.Font("Roboto", 21.75F);
            this.lblConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConfirmation.Location = new System.Drawing.Point(3, 3);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(786, 92);
            this.lblConfirmation.TabIndex = 16;
            this.lblConfirmation.Text = "Do you really wanna send this query ?";
            this.lblConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbThanksMsg
            // 
            this.tbThanksMsg.Controls.Add(this.lblThanks);
            this.tbThanksMsg.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThanksMsg.Location = new System.Drawing.Point(4, 22);
            this.tbThanksMsg.Name = "tbThanksMsg";
            this.tbThanksMsg.Padding = new System.Windows.Forms.Padding(20);
            this.tbThanksMsg.Size = new System.Drawing.Size(792, 471);
            this.tbThanksMsg.TabIndex = 4;
            this.tbThanksMsg.UseVisualStyleBackColor = true;
            // 
            // lblThanks
            // 
            this.lblThanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThanks.Font = new System.Drawing.Font("Roboto", 21.75F);
            this.lblThanks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThanks.Location = new System.Drawing.Point(20, 20);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(752, 431);
            this.lblThanks.TabIndex = 17;
            this.lblThanks.Text = "Thanks message";
            this.lblThanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThanks.Click += new System.EventHandler(this.label4_Click);
            // 
            // tnxTimer
            // 
            this.tnxTimer.Interval = 3000;
            this.tnxTimer.Tick += new System.EventHandler(this.cxtimer_Tick);
            // 
            // PageTimer
            // 
            this.PageTimer.Interval = 30000;
            this.PageTimer.Tick += new System.EventHandler(this.PageTimer_Tick);
            // 
            // msgTimer
            // 
            this.msgTimer.Interval = 110000;
            this.msgTimer.Tick += new System.EventHandler(this.msgTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hajj Communicator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.mainTabControl.ResumeLayout(false);
            this.tbMsg.ResumeLayout(false);
            this.tbLanguageSelection.ResumeLayout(false);
            this.tbLanguageSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btUrdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btArabic)).EndInit();
            this.tbQueryType.ResumeLayout(false);
            this.tbQueryType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCleaning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBack)).EndInit();
            this.tbQuery.ResumeLayout(false);
            this.tbQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btBack1)).EndInit();
            this.tbConfirmation.ResumeLayout(false);
            this.tbConfirmation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBack2)).EndInit();
            this.tbThanksMsg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage tbLanguageSelection;
        private System.Windows.Forms.TabPage tbQueryType;
        private System.Windows.Forms.PictureBox btUrdu;
        private System.Windows.Forms.PictureBox btEnglish;
        private System.Windows.Forms.PictureBox btArabic;
        private System.Windows.Forms.TabPage tbQuery;
        private System.Windows.Forms.TabPage tbConfirmation;
        private System.Windows.Forms.TabPage tbThanksMsg;
        private System.Windows.Forms.TabPage tbMsg;
        private System.Windows.Forms.Timer tnxTimer;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblSelectLanguage;
        private System.Windows.Forms.Label lblDestinationQuery;
        private System.Windows.Forms.Label lblArabic;
        private System.Windows.Forms.Label lblUrdu;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblQuerySelection;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer PageTimer;
        private System.Windows.Forms.PictureBox btBack;
        private System.Windows.Forms.PictureBox btBack1;
        private System.Windows.Forms.PictureBox btBack2;
        private System.Windows.Forms.PictureBox btCancel;
        private System.Windows.Forms.PictureBox btSend;
        private System.Windows.Forms.Timer msgTimer;
        private System.Windows.Forms.PictureBox btCleaning;
        private System.Windows.Forms.PictureBox btMaintenance;
        private System.Windows.Forms.PictureBox btFood;
        private System.Windows.Forms.PictureBox btHealth;
        private System.Windows.Forms.Label lblCleaning;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblHealth;
    }
}

