namespace Simple_Face_Recognition_App
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.label_hello = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.taskbar_dashboard = new XanderUI.XUISuperButton();
            this.taskbar_dataViewer = new XanderUI.XUISuperButton();
            this.taskbar_settings = new XanderUI.XUISuperButton();
            this.panel_layout1 = new System.Windows.Forms.TableLayoutPanel();
            this.piccap = new System.Windows.Forms.PictureBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_detect = new XanderUI.XUISuperButton();
            this.button_recognize = new XanderUI.XUISuperButton();
            this.button_train = new XanderUI.XUISuperButton();
            this.button_add = new XanderUI.XUISuperButton();
            this.button_capture = new XanderUI.XUISuperButton();
            this.picn2 = new System.Windows.Forms.PictureBox();
            this.picn1 = new System.Windows.Forms.PictureBox();
            this.pictureboxdet = new System.Windows.Forms.PictureBox();
            this.picbox_timeline = new System.Windows.Forms.PictureBox();
            this.hoverSetting = new System.Windows.Forms.PictureBox();
            this.hoverData = new System.Windows.Forms.PictureBox();
            this.hoverDash = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Name = new System.Windows.Forms.Label();
            this.panel_dashboard = new System.Windows.Forms.TableLayoutPanel();
            this.label_CamNum = new System.Windows.Forms.Label();
            this.label_settingDes = new System.Windows.Forms.Label();
            this.button_openSetting = new XanderUI.XUISuperButton();
            this.button_ManageAcc = new XanderUI.XUISuperButton();
            this.Rbutton_storage2 = new XanderUI.XUIRadio();
            this.Rbutton_storage1 = new XanderUI.XUIRadio();
            this.panel_setting = new System.Windows.Forms.TableLayoutPanel();
            this.panel_hoverSetting = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_layout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccap)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_timeline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoverSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoverData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoverDash)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel_dashboard.SuspendLayout();
            this.panel_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_hoverSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.BackColor = System.Drawing.Color.Transparent;
            this.label_hello.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hello.ForeColor = System.Drawing.Color.White;
            this.label_hello.Location = new System.Drawing.Point(87, 89);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(57, 21);
            this.label_hello.TabIndex = 0;
            this.label_hello.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.taskbar_dashboard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.taskbar_dataViewer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.taskbar_settings, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 253);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(48, 142);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // taskbar_dashboard
            // 
            this.taskbar_dashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.taskbar_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.taskbar_dashboard.ButtonImage = global::Simple_Face_Recognition_App.Properties.Resources.Body_button_menu_dashboard;
            this.taskbar_dashboard.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.taskbar_dashboard.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.taskbar_dashboard.ButtonText = "";
            this.taskbar_dashboard.CornerRadius = 5;
            this.taskbar_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskbar_dashboard.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.taskbar_dashboard.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(95)))));
            this.taskbar_dashboard.HoverTextColor = System.Drawing.Color.White;
            this.taskbar_dashboard.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.taskbar_dashboard.Location = new System.Drawing.Point(3, 3);
            this.taskbar_dashboard.Name = "taskbar_dashboard";
            this.taskbar_dashboard.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.taskbar_dashboard.SelectedTextColor = System.Drawing.Color.White;
            this.taskbar_dashboard.Size = new System.Drawing.Size(42, 41);
            this.taskbar_dashboard.SuperSelected = false;
            this.taskbar_dashboard.TabIndex = 21;
            this.taskbar_dashboard.TextColor = System.Drawing.Color.White;
            this.taskbar_dashboard.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.taskbar_dashboard.Click += new System.EventHandler(this.Taskbar_dashboard_Click);
            // 
            // taskbar_dataViewer
            // 
            this.taskbar_dataViewer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.taskbar_dataViewer.ButtonImage = global::Simple_Face_Recognition_App.Properties.Resources.Body_button_menu_database;
            this.taskbar_dataViewer.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.taskbar_dataViewer.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.taskbar_dataViewer.ButtonText = "";
            this.taskbar_dataViewer.CornerRadius = 5;
            this.taskbar_dataViewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskbar_dataViewer.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.taskbar_dataViewer.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(95)))));
            this.taskbar_dataViewer.HoverTextColor = System.Drawing.Color.White;
            this.taskbar_dataViewer.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.taskbar_dataViewer.Location = new System.Drawing.Point(3, 50);
            this.taskbar_dataViewer.Name = "taskbar_dataViewer";
            this.taskbar_dataViewer.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.taskbar_dataViewer.SelectedTextColor = System.Drawing.Color.White;
            this.taskbar_dataViewer.Size = new System.Drawing.Size(42, 41);
            this.taskbar_dataViewer.SuperSelected = false;
            this.taskbar_dataViewer.TabIndex = 21;
            this.taskbar_dataViewer.TextColor = System.Drawing.Color.White;
            this.taskbar_dataViewer.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.taskbar_dataViewer.Click += new System.EventHandler(this.taskbar_dataViewer_Click);
            // 
            // taskbar_settings
            // 
            this.taskbar_settings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.taskbar_settings.ButtonImage = global::Simple_Face_Recognition_App.Properties.Resources.Body_button_menu_settings;
            this.taskbar_settings.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.taskbar_settings.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.taskbar_settings.ButtonText = "";
            this.taskbar_settings.CornerRadius = 5;
            this.taskbar_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskbar_settings.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.taskbar_settings.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(95)))));
            this.taskbar_settings.HoverTextColor = System.Drawing.Color.White;
            this.taskbar_settings.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.taskbar_settings.Location = new System.Drawing.Point(3, 97);
            this.taskbar_settings.Name = "taskbar_settings";
            this.taskbar_settings.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.taskbar_settings.SelectedTextColor = System.Drawing.Color.White;
            this.taskbar_settings.Size = new System.Drawing.Size(42, 41);
            this.taskbar_settings.SuperSelected = false;
            this.taskbar_settings.TabIndex = 21;
            this.taskbar_settings.TextColor = System.Drawing.Color.White;
            this.taskbar_settings.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.taskbar_settings.Click += new System.EventHandler(this.Taskbar_settings_Click);
            // 
            // panel_layout1
            // 
            this.panel_layout1.BackColor = System.Drawing.Color.Transparent;
            this.panel_layout1.ColumnCount = 1;
            this.panel_layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_layout1.Controls.Add(this.piccap, 0, 0);
            this.panel_layout1.Location = new System.Drawing.Point(3, 3);
            this.panel_layout1.Name = "panel_layout1";
            this.panel_layout1.RowCount = 1;
            this.panel_layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.704641F));
            this.panel_layout1.Size = new System.Drawing.Size(455, 257);
            this.panel_layout1.TabIndex = 4;
            // 
            // piccap
            // 
            this.piccap.Location = new System.Drawing.Point(3, 3);
            this.piccap.Name = "piccap";
            this.piccap.Size = new System.Drawing.Size(449, 250);
            this.piccap.TabIndex = 0;
            this.piccap.TabStop = false;
            // 
            // txtbox_name
            // 
            this.txtbox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.txtbox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_name.Location = new System.Drawing.Point(350, 471);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(100, 23);
            this.txtbox_name.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button_detect, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_recognize, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_train, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_add, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_capture, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 269);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(455, 28);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // button_detect
            // 
            this.button_detect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_detect.ButtonImage = null;
            this.button_detect.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.button_detect.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.button_detect.ButtonText = "Detect";
            this.button_detect.CornerRadius = 10;
            this.button_detect.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_detect.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_detect.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.button_detect.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.button_detect.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.button_detect.Location = new System.Drawing.Point(94, 3);
            this.button_detect.Name = "button_detect";
            this.button_detect.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_detect.SelectedTextColor = System.Drawing.Color.White;
            this.button_detect.Size = new System.Drawing.Size(85, 22);
            this.button_detect.SuperSelected = false;
            this.button_detect.TabIndex = 1;
            this.button_detect.TextColor = System.Drawing.Color.Empty;
            this.button_detect.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_detect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // button_recognize
            // 
            this.button_recognize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_recognize.ButtonImage = null;
            this.button_recognize.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.button_recognize.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.button_recognize.ButtonText = "Recognize";
            this.button_recognize.CornerRadius = 10;
            this.button_recognize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_recognize.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_recognize.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.button_recognize.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.button_recognize.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.button_recognize.Location = new System.Drawing.Point(367, 3);
            this.button_recognize.Name = "button_recognize";
            this.button_recognize.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_recognize.SelectedTextColor = System.Drawing.Color.White;
            this.button_recognize.Size = new System.Drawing.Size(85, 22);
            this.button_recognize.SuperSelected = false;
            this.button_recognize.TabIndex = 2;
            this.button_recognize.TextColor = System.Drawing.Color.Empty;
            this.button_recognize.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_recognize.Click += new System.EventHandler(this.btnrec_Click);
            // 
            // button_train
            // 
            this.button_train.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_train.ButtonImage = null;
            this.button_train.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.button_train.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.button_train.ButtonText = "Train";
            this.button_train.CornerRadius = 10;
            this.button_train.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_train.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_train.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.button_train.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.button_train.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.button_train.Location = new System.Drawing.Point(276, 3);
            this.button_train.Name = "button_train";
            this.button_train.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_train.SelectedTextColor = System.Drawing.Color.White;
            this.button_train.Size = new System.Drawing.Size(85, 22);
            this.button_train.SuperSelected = false;
            this.button_train.TabIndex = 3;
            this.button_train.TextColor = System.Drawing.Color.Empty;
            this.button_train.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_train.Click += new System.EventHandler(this.btntrain_Click);
            // 
            // button_add
            // 
            this.button_add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_add.ButtonImage = null;
            this.button_add.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.button_add.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.button_add.ButtonText = "Add";
            this.button_add.CornerRadius = 10;
            this.button_add.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_add.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.button_add.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.button_add.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.button_add.Location = new System.Drawing.Point(185, 3);
            this.button_add.Name = "button_add";
            this.button_add.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_add.SelectedTextColor = System.Drawing.Color.White;
            this.button_add.Size = new System.Drawing.Size(85, 22);
            this.button_add.SuperSelected = false;
            this.button_add.TabIndex = 4;
            this.button_add.TextColor = System.Drawing.Color.Empty;
            this.button_add.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_add.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button_capture
            // 
            this.button_capture.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_capture.ButtonImage = null;
            this.button_capture.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.button_capture.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.button_capture.ButtonText = "Capture";
            this.button_capture.CornerRadius = 10;
            this.button_capture.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_capture.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_capture.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.button_capture.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.button_capture.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.button_capture.Location = new System.Drawing.Point(3, 3);
            this.button_capture.Name = "button_capture";
            this.button_capture.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_capture.SelectedTextColor = System.Drawing.Color.White;
            this.button_capture.Size = new System.Drawing.Size(85, 22);
            this.button_capture.SuperSelected = false;
            this.button_capture.TabIndex = 0;
            this.button_capture.TextColor = System.Drawing.Color.Empty;
            this.button_capture.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_capture.Click += new System.EventHandler(this.btncap_Click);
            // 
            // picn2
            // 
            this.picn2.Location = new System.Drawing.Point(161, 3);
            this.picn2.Name = "picn2";
            this.picn2.Size = new System.Drawing.Size(71, 121);
            this.picn2.TabIndex = 16;
            this.picn2.TabStop = false;
            // 
            // picn1
            // 
            this.picn1.Location = new System.Drawing.Point(89, 3);
            this.picn1.Name = "picn1";
            this.picn1.Size = new System.Drawing.Size(66, 121);
            this.picn1.TabIndex = 15;
            this.picn1.TabStop = false;
            // 
            // pictureboxdet
            // 
            this.pictureboxdet.Location = new System.Drawing.Point(3, 3);
            this.pictureboxdet.Name = "pictureboxdet";
            this.pictureboxdet.Size = new System.Drawing.Size(80, 121);
            this.pictureboxdet.TabIndex = 13;
            this.pictureboxdet.TabStop = false;
            // 
            // picbox_timeline
            // 
            this.picbox_timeline.BackColor = System.Drawing.Color.Transparent;
            this.picbox_timeline.BackgroundImage = global::Simple_Face_Recognition_App.Properties.Resources.Body_shape_cameraSec;
            this.picbox_timeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_timeline.Location = new System.Drawing.Point(553, 140);
            this.picbox_timeline.Name = "picbox_timeline";
            this.picbox_timeline.Size = new System.Drawing.Size(532, 271);
            this.picbox_timeline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_timeline.TabIndex = 6;
            this.picbox_timeline.TabStop = false;
            // 
            // hoverSetting
            // 
            this.hoverSetting.BackColor = System.Drawing.Color.Transparent;
            this.hoverSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hoverSetting.Location = new System.Drawing.Point(6, 356);
            this.hoverSetting.Name = "hoverSetting";
            this.hoverSetting.Size = new System.Drawing.Size(5, 30);
            this.hoverSetting.TabIndex = 3;
            this.hoverSetting.TabStop = false;
            this.hoverSetting.Visible = false;
            // 
            // hoverData
            // 
            this.hoverData.BackColor = System.Drawing.Color.Transparent;
            this.hoverData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hoverData.Location = new System.Drawing.Point(6, 310);
            this.hoverData.Name = "hoverData";
            this.hoverData.Size = new System.Drawing.Size(5, 30);
            this.hoverData.TabIndex = 3;
            this.hoverData.TabStop = false;
            this.hoverData.Visible = false;
            // 
            // hoverDash
            // 
            this.hoverDash.BackColor = System.Drawing.Color.Transparent;
            this.hoverDash.BackgroundImage = global::Simple_Face_Recognition_App.Properties.Resources.Body_shape_menu_hover;
            this.hoverDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hoverDash.Location = new System.Drawing.Point(6, 264);
            this.hoverDash.Name = "hoverDash";
            this.hoverDash.Size = new System.Drawing.Size(5, 30);
            this.hoverDash.TabIndex = 3;
            this.hoverDash.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.71429F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel3.Controls.Add(this.picn2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_Name, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.picn1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureboxdet, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(455, 127);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.label_Name.Location = new System.Drawing.Point(238, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(42, 15);
            this.label_Name.TabIndex = 19;
            this.label_Name.Text = "Name:";
            // 
            // panel_dashboard
            // 
            this.panel_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.panel_dashboard.ColumnCount = 1;
            this.panel_dashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_dashboard.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.panel_dashboard.Controls.Add(this.panel_layout1, 0, 0);
            this.panel_dashboard.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.panel_dashboard.Location = new System.Drawing.Point(89, 151);
            this.panel_dashboard.Name = "panel_dashboard";
            this.panel_dashboard.RowCount = 3;
            this.panel_dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.66666F));
            this.panel_dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33333F));
            this.panel_dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.panel_dashboard.Size = new System.Drawing.Size(461, 441);
            this.panel_dashboard.TabIndex = 20;
            // 
            // label_CamNum
            // 
            this.label_CamNum.AutoSize = true;
            this.label_CamNum.BackColor = System.Drawing.Color.Transparent;
            this.label_CamNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CamNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.label_CamNum.Location = new System.Drawing.Point(97, 140);
            this.label_CamNum.Name = "label_CamNum";
            this.label_CamNum.Size = new System.Drawing.Size(55, 15);
            this.label_CamNum.TabIndex = 19;
            this.label_CamNum.Text = "Camera 1";
            // 
            // label_settingDes
            // 
            this.label_settingDes.AutoSize = true;
            this.label_settingDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(75)))));
            this.label_settingDes.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label_settingDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.label_settingDes.Location = new System.Drawing.Point(565, 150);
            this.label_settingDes.MaximumSize = new System.Drawing.Size(335, 500);
            this.label_settingDes.Name = "label_settingDes";
            this.label_settingDes.Size = new System.Drawing.Size(320, 114);
            this.label_settingDes.TabIndex = 25;
            this.label_settingDes.Text = resources.GetString("label_settingDes.Text");
            // 
            // button_openSetting
            // 
            this.button_openSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_openSetting.ButtonImage = null;
            this.button_openSetting.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.button_openSetting.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.button_openSetting.ButtonText = "Open Setting";
            this.button_openSetting.CornerRadius = 5;
            this.button_openSetting.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openSetting.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_openSetting.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.button_openSetting.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.button_openSetting.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.button_openSetting.Location = new System.Drawing.Point(3, 78);
            this.button_openSetting.Name = "button_openSetting";
            this.button_openSetting.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_openSetting.SelectedTextColor = System.Drawing.Color.White;
            this.button_openSetting.Size = new System.Drawing.Size(100, 25);
            this.button_openSetting.SuperSelected = false;
            this.button_openSetting.TabIndex = 26;
            this.button_openSetting.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.button_openSetting.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_openSetting.Click += new System.EventHandler(this.button_openSetting_Click);
            // 
            // button_ManageAcc
            // 
            this.button_ManageAcc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_ManageAcc.ButtonImage = null;
            this.button_ManageAcc.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.button_ManageAcc.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.button_ManageAcc.ButtonText = "Manage Accounts";
            this.button_ManageAcc.CornerRadius = 5;
            this.button_ManageAcc.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageAcc.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_ManageAcc.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(76)))));
            this.button_ManageAcc.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.button_ManageAcc.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.button_ManageAcc.Location = new System.Drawing.Point(131, 166);
            this.button_ManageAcc.Name = "button_ManageAcc";
            this.button_ManageAcc.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.button_ManageAcc.SelectedTextColor = System.Drawing.Color.White;
            this.button_ManageAcc.Size = new System.Drawing.Size(200, 25);
            this.button_ManageAcc.SuperSelected = false;
            this.button_ManageAcc.TabIndex = 26;
            this.button_ManageAcc.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.button_ManageAcc.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_ManageAcc.Click += new System.EventHandler(this.button_ManageAcc_Click);
            // 
            // Rbutton_storage2
            // 
            this.Rbutton_storage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.Rbutton_storage2.Checked = false;
            this.Rbutton_storage2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbutton_storage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.Rbutton_storage2.Location = new System.Drawing.Point(131, 3);
            this.Rbutton_storage2.Name = "Rbutton_storage2";
            this.Rbutton_storage2.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.Rbutton_storage2.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.Rbutton_storage2.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.Rbutton_storage2.Size = new System.Drawing.Size(124, 18);
            this.Rbutton_storage2.TabIndex = 26;
            this.Rbutton_storage2.Text = "Local Database";
            this.Rbutton_storage2.MouseLeave += new System.EventHandler(this.Rbutton_storage1_MouseLeave);
            this.Rbutton_storage2.MouseHover += new System.EventHandler(this.Rbutton_storage1_MouseHover);
            // 
            // Rbutton_storage1
            // 
            this.Rbutton_storage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.Rbutton_storage1.Checked = false;
            this.Rbutton_storage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbutton_storage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.Rbutton_storage1.Location = new System.Drawing.Point(3, 3);
            this.Rbutton_storage1.Name = "Rbutton_storage1";
            this.Rbutton_storage1.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.Rbutton_storage1.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.Rbutton_storage1.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.Rbutton_storage1.Size = new System.Drawing.Size(100, 18);
            this.Rbutton_storage1.TabIndex = 26;
            this.Rbutton_storage1.Text = "Local folder";
            this.Rbutton_storage1.MouseLeave += new System.EventHandler(this.Rbutton_storage1_MouseLeave);
            this.Rbutton_storage1.MouseHover += new System.EventHandler(this.Rbutton_storage1_MouseHover);
            // 
            // panel_setting
            // 
            this.panel_setting.BackColor = System.Drawing.Color.Transparent;
            this.panel_setting.ColumnCount = 2;
            this.panel_setting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.62275F));
            this.panel_setting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.37725F));
            this.panel_setting.Controls.Add(this.Rbutton_storage1, 0, 0);
            this.panel_setting.Controls.Add(this.button_openSetting, 0, 1);
            this.panel_setting.Controls.Add(this.Rbutton_storage2, 1, 0);
            this.panel_setting.Controls.Add(this.button_ManageAcc, 1, 2);
            this.panel_setting.Location = new System.Drawing.Point(213, 161);
            this.panel_setting.Name = "panel_setting";
            this.panel_setting.RowCount = 3;
            this.panel_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.83333F));
            this.panel_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.16667F));
            this.panel_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.panel_setting.Size = new System.Drawing.Size(334, 229);
            this.panel_setting.TabIndex = 26;
            // 
            // panel_hoverSetting
            // 
            this.panel_hoverSetting.BackColor = System.Drawing.Color.Transparent;
            this.panel_hoverSetting.BackgroundImage = global::Simple_Face_Recognition_App.Properties.Resources.Body_shape_cameraSec;
            this.panel_hoverSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_hoverSetting.Location = new System.Drawing.Point(558, 136);
            this.panel_hoverSetting.Name = "panel_hoverSetting";
            this.panel_hoverSetting.Size = new System.Drawing.Size(345, 196);
            this.panel_hoverSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel_hoverSetting.TabIndex = 6;
            this.panel_hoverSetting.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Simple_Face_Recognition_App.Properties.Resources.Setting_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 635);
            this.Controls.Add(this.panel_setting);
            this.Controls.Add(this.label_settingDes);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.label_CamNum);
            this.Controls.Add(this.panel_dashboard);
            this.Controls.Add(this.panel_hoverSetting);
            this.Controls.Add(this.picbox_timeline);
            this.Controls.Add(this.label_hello);
            this.Controls.Add(this.hoverSetting);
            this.Controls.Add(this.hoverData);
            this.Controls.Add(this.hoverDash);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1118, 674);
            this.MinimumSize = new System.Drawing.Size(1118, 674);
            this.Name = "HomePage";
            this.Opacity = 0.98D;
            this.Text = "Face Detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_layout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piccap)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_timeline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoverSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoverData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoverDash)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel_dashboard.ResumeLayout(false);
            this.panel_setting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_hoverSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox hoverDash;
        private System.Windows.Forms.PictureBox hoverData;
        private System.Windows.Forms.PictureBox hoverSetting;
        private System.Windows.Forms.TableLayoutPanel panel_layout1;
        private System.Windows.Forms.PictureBox picbox_timeline;
        private System.Windows.Forms.PictureBox piccap;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.PictureBox pictureboxdet;
        private System.Windows.Forms.PictureBox picn1;
        private System.Windows.Forms.PictureBox picn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private XanderUI.XUISuperButton button_capture;
        private XanderUI.XUISuperButton button_detect;
        private XanderUI.XUISuperButton button_recognize;
        private XanderUI.XUISuperButton button_train;
        private XanderUI.XUISuperButton button_add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TableLayoutPanel panel_dashboard;
        private System.Windows.Forms.Label label_CamNum;
        private XanderUI.XUISuperButton taskbar_dashboard;
        private XanderUI.XUISuperButton taskbar_dataViewer;
        private XanderUI.XUISuperButton taskbar_settings;
        private System.Windows.Forms.Label label_settingDes;
        private XanderUI.XUISuperButton button_openSetting;
        private XanderUI.XUISuperButton button_ManageAcc;
        private XanderUI.XUIRadio Rbutton_storage2;
        private XanderUI.XUIRadio Rbutton_storage1;
        private System.Windows.Forms.TableLayoutPanel panel_setting;
        private System.Windows.Forms.PictureBox panel_hoverSetting;
    }
}