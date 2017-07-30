﻿

namespace game1
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        //enemyPictureBox1 برای تعیین مسیر حرکت Path از نوع کلاس path1 تعریف 
        public Path Path1 = new Path(5,2);
        
        //enemyPictureBox2 برای تعیین مسیر حرکت Path از نوع کلاس path2 تعریف 
        public Path Path2 = new Path(-3, 4);
       
        //enemyPictureBox3 برای تعیین مسیر حرکت Path از نوع کلاس path3 تعریف 
        public Path Path3 = new Path(1, -5);
       
        //enemyPictureBox4 برای تعیین مسیر حرکت Path از نوع کلاس path4 تعریف 
        public Path Path4 = new Path(-5, -6);


        public MainForm()
        {
            InitializeComponent();

        }

        protected override bool ProcessDialogKey(System.Windows.Forms.Keys keyData)
        {
            // فراخوانی تابع جهت 
            // با دکمه های کیبورد targetPictureBox حرکت
            this.MoveControlByKeys(keyData, targetPictureBox);

            return base.ProcessDialogKey(keyData);
        }

        // با دکمه های کیبورد targetPictureBox تابع حرکت

        private void MoveControlByKeys(System.Windows.Forms.Keys keyData,
                            System.Windows.Forms.Control control)

        {//باشدleft اگر دکمه فشار داده شده دکمه 
            if (keyData == System.Windows.Forms.Keys.Left)
            {
                //     میباشد mainPanel و اگر هنوز کنترل در محدوده 
                if (control.Location.X > 0)
                {
                    //      موقعیت کنترل را یک واحد به چپ انتقال می دهیم
                    control.Location = new System.Drawing.Point
                             (control.Location.X - 1, control.Location.Y);
                }
            }
            //باشدright اگر دکمه فشار داده شده دکمه 
            else if (keyData == System.Windows.Forms.Keys.Right)
            {
                //میباشد mainPanel و اگر هنوز کنترل در محدوده
                if (control.Location.X <
                                mainPanel.Width - control.Width)
                {
                    // //      موقعیت کنترل را یک واحد به راست انتقال می دهیم
                    control.Location = new System.Drawing.Point
                            (control.Location.X + 1, control.Location.Y);
                }
            }
            //باشدup اگر دکمه فشار داده شده دکمه 
            else if (keyData == System.Windows.Forms.Keys.Up)
            {
                //میباشد mainPanel و اگر هنوز کنترل در محدوده
                if (control.Location.Y > 0)
                {
                    //      موقعیت کنترل را یک واحد به بالا انتقال می دهیم
                    control.Location = new System.Drawing.Point
                            (control.Location.X, control.Location.Y - 1);
                }
            }
            //باشدdown اگر دکمه فشار داده شده دکمه 
            else if (keyData == System.Windows.Forms.Keys.Down)
            {
                //میباشد mainPanel و اگر هنوز کنترل در محدوده
                if (control.Location.Y <
                                 mainPanel.Height - control.Height)
                {
                    //      موقعیت کنترل را یک واحد به پایین انتقال می دهیم
                    control.Location = new System.Drawing.Point
                            (control.Location.X, control.Location.Y + 1);
                }
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {

            //  فعال باشد بازی شروع نشده و خارج میشود  goButton اگر دکمه

            if (goButton.Enabled)
            {

                return;      
            }
            //   بازی شروع شده 
            string strLevel = levelComboBox.Text;     //  های فغالenemyPitureBox تعداد

            switch (strLevel)
            {
                case "4":
                    {
                        // فراخوانی تابع جهت چک برخورد
                        //برخورد نکرده باشد targetPictureBox با enemyPictureBox4 اگر
                        if (CheckAccident(enemyPictureBox4) == false)
                        {
                            //Path4 در مسیر enemyPictureBox4 فراخوانی تابع جهت حرکت
                            MoveEnemy(enemyPictureBox4, Path4);

                            //(فراخوانی تابع)
                            //   mainPanel  با مرز enemyPictureBox4 در صورتیکه
                            //دریافت میکندPath4 برخورد کند شیب جدید به صورت رندوم برای
                            Path4.checkToGetNewSlope(enemyPictureBox4,
                                maxTop: mainPanel.Height - enemyPictureBox4.Height,
                                    maxLeft: mainPanel.Width - enemyPictureBox4 .Width);

                        }
                        //به حالت 3 می رود
                        goto case "3";
                    }
                case "3":
                    {
                        // فراخوانی تابع جهت چک برخورد
                        //برخورد نکرده باشد targetPictureBox با enemyPictureBox3 اگر
                        if (CheckAccident(enemyPictureBox3) == false)
                        {
                            //Path3 در مسیر enemyPictureBox3 فراخوانی تابع جهت حرکت
                            MoveEnemy(enemyPictureBox3, Path3);

                            //(فراخوانی تابع)
                            //   mainPanel  با مرز enemyPictureBox3 در صورتیکه
                            //دریافت میکندPath3 برخورد کند شیب جدید به صورت رندوم برای
                            Path3.checkToGetNewSlope(enemyPictureBox3,
                                maxTop: mainPanel.Height - enemyPictureBox3.Height,
                                    maxLeft: mainPanel.Width - enemyPictureBox3.Width);

                        }

                        goto case "2";
                    }
                case "2":
                    {
                        // فراخوانی تابع جهت چک برخورد
                        //برخورد نکرده باشد targetPictureBox با enemyPictureBox2 اگر
                        if (CheckAccident(enemyPictureBox2) == false)
                        {
                            //Path2 در مسیر enemyPictureBox2 فراخوانی تابع جهت حرکت
                            MoveEnemy(enemyPictureBox2, Path2);

                            //(فراخوانی تابع)
                            //   mainPanel  با مرز enemyPictureBox2 در صورتیکه
                            //دریافت میکندPath2 برخورد کند شیب جدید به صورت رندوم برای
                            Path2.checkToGetNewSlope(enemyPictureBox2,
                                maxTop: mainPanel.Height - enemyPictureBox2.Height,
                                    maxLeft: mainPanel.Width - enemyPictureBox2.Width);

                        }

                        goto case "1";
                    }

                case "1":
                    {
                        // فراخوانی تابع جهت چک برخورد
                        //برخورد نکرده باشد targetPictureBox با enemyPictureBox1 اگر
                        if (CheckAccident(enemyPictureBox1) == false)
                        {
                            //Path1 در مسیر enemyPictureBox1 فراخوانی تابع جهت حرکت
                            MoveEnemy(enemyPictureBox1,Path1);

                            //(فراخوانی تابع)
                            //   mainPanel  با مرز enemyPictureBox1 در صورتیکه
                            //دریافت میکندPath1 برخورد کند شیب جدید به صورت رندوم برای
                            Path1.checkToGetNewSlope(enemyPictureBox1,
                                maxTop:mainPanel.Height-enemyPictureBox1.Height,
                                    maxLeft:mainPanel.Width-enemyPictureBox1.Width);

                        }

                        break;
                    }
            }
        }

        // حرکت میدهد Path را در مسیر  enemy
        //  خارج نشود و حتما با مرز برخورد کند mainPanel به طوری که از محدوده 
        public void MoveEnemy(System.Windows.Forms.PictureBox enemy,Path path)
        {
            //اگر حرکت به سمت چپ باشد 
            if (path.SlopeX<0)
            {
                // به سمت چپ حرکت کرده   SlopeX به اندازه 
                //ومانع خارج شدن از مرز می شود 
                enemy.Left = 
                    System.Math.Max(0, enemy.Left + path.SlopeX);

            }
            //در غیر این صورت حرکت به سمت راست می باشد
            else
            {
                // به سمت راست حرکت کرده   SlopeX به اندازه 
                //ومانع خارج شدن از مرز می شود
                enemy.Left = 
                    System.Math.Min(mainPanel.Width-enemy.Width, enemy.Left + path.SlopeX);
            }

            //اگر حرکت به سمت بالا باشد 
            if (path.SlopeY< 0)
            {
                // به سمت بالا حرکت کرده   SlopeY به اندازه 
                //ومانع خارج شدن از مرز می شود
                enemy.Top =
                    System.Math.Max(0, enemy.Top + path.SlopeY);

            }
            //در غیر این صورت حرکت به سمت پایین می باشد
            else
            {
                // به سمت پایین حرکت کرده   SlopeY به اندازه 
                //ومانع خارج شدن از مرز می شود
                enemy.Top =
                    System.Math.Min(mainPanel.Height - enemy.Height, enemy.Top + path.SlopeY);
            }
        }

        //targetPictureBox با enemy در صورت برخورد 
        //برمیگرداند وپیغام می دهد True تابع مقدار 

        public bool CheckAccident(System.Windows.Forms.PictureBox enemy)
        {
            //تعریف متغیر برای تعیین برخورد افقی 
            bool boolVerticalAccident = false;

            //تعریف متغیر برای تعیین برخورد عمودی
            bool boolHorizentalAccident = false;

            //شعاع محدوده برخورد افقی
            int intWidthBound =
                (enemy.Width + targetPictureBox.Width) / 2;

            // شعاع محدوده برخورد عمودی
            int intHeightBound =
                (enemy.Height + targetPictureBox.Height) / 2;

            // اگر برخورد افقی رخ داده 
            if (System.Math.Abs(targetPictureBox.Left - enemy.Left)
                        <= intWidthBound)
            {
                //میکنیم true متغیر مربوطه را 
                boolHorizentalAccident = true;
            }

            // اگر برخورد عمودی رخ داده
            if (System.Math.Abs(targetPictureBox.Top - enemy.Top)
                        <= intHeightBound)
            {
                //میکنیم true متغیر مربوطه را
                boolVerticalAccident = true;

            }
            
            //چنانچه برخوردی رخ داده باشد
            if (boolVerticalAccident && boolHorizentalAccident)
            {
                //  غیر فعال می کنیم timer1 
                timer1.Enabled = false;

                //پنجره دیالوگ نمایش داده می شود که با انتخاب کاربر 
                //می شود reset از بازی خارج شده یا برای ادامه بازی فرم 
                System.Windows.Forms.DialogResult enmResult =
                               System.Windows.Forms.MessageBox.Show
                               (text: "The game is over, Do you want to exit?",
                                caption: "Question",
                                buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                                icon: System.Windows.Forms.MessageBoxIcon.Question,
                                defaultButton:
                                   System.Windows.Forms.MessageBoxDefaultButton.Button2);

                if (enmResult == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else
                {

                    resetForm();
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private void resetForm()
        {

            //levelComboBox.Focus();

            //برای شروع بازی فعال میشود و نیز goButton 
            //فعال می شود enemyPictureBox  برای تعیین تعداد  levelComboBox 
            startGroupBox.Enabled = true;
            
            //کلیدهای حرکت فعال میشوند 
            arrowKeyGroupBox.Enabled = false;

            // غیر فعال می شود timer1 
            timer1.Enabled = false;

            //در موقعیت پیش فرض ما قرار می گیرند pictureBox 
            targetPictureBox.Left =
                    (mainPanel.Width - targetPictureBox.Width) / 2;

            targetPictureBox.Top =
                    (mainPanel.Height - targetPictureBox.Height) / 2;

            enemyPictureBox1.Top = 0;

            enemyPictureBox1.Left = 0;

            enemyPictureBox2.Top = 0;

            enemyPictureBox2.Left = mainPanel.Width - enemyPictureBox2.Width;

            enemyPictureBox3.Top = mainPanel.Height - enemyPictureBox3.Height;

            enemyPictureBox3.Left = 0;

            enemyPictureBox4.Top = mainPanel.Height - enemyPictureBox4.Height;

            enemyPictureBox4.Left = mainPanel.Width - enemyPictureBox4.Width;

        }

        // یازی شروع می شود goButton با زدن دکمه
      private void goButton_Click(object sender, System.EventArgs e)
        {
            // غیر فعال میشود و نیز goButton 
            //غیر فعال می شود  levelComboBox 
            startGroupBox.Enabled = false;

            //  فعال و یازی شروع می شود timer1 
            timer1.Enabled = true;

            //کلیدهای حرکت فعال میشوند
            arrowKeyGroupBox.Enabled = true;

        }

        // فعالenemyPitureBox تعیین تعداد

        private void levelComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string strLevel = levelComboBox.Text;

            switch (strLevel)
            {
                case"1":
                    {
                        //( فعال است (پیش فرض enemyPictureBox1 در این حالت تنها 
                        enemyPictureBox2.Visible = false;

                        enemyPictureBox3.Visible = false;

                        enemyPictureBox4.Visible = false;

                        resetForm();

                        break;
                    }

                case "2":
                    {
                        enemyPictureBox2.Visible = true;

                        enemyPictureBox3.Visible = false;

                        enemyPictureBox4.Visible = false;

                        resetForm();

                        break;
                    }
                case"3":
                    {
                        enemyPictureBox2.Visible = true;

                        enemyPictureBox3.Visible = true;

                        enemyPictureBox4.Visible = false;

                        resetForm();

                        break;
                    }
                case"4":
                    {
                        enemyPictureBox2.Visible = true;

                        enemyPictureBox3.Visible = true;

                        enemyPictureBox4.Visible = true;

                        resetForm();

                        break;
                    }
            }

        }

        //خروج از برنامه 

        private void exitToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult enmResult =
                   System.Windows.Forms.MessageBox.Show
                   (text: "آیا به خروج از برنامه اطمینان دارید؟",
                    caption: "سوال",
                    buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                    icon: System.Windows.Forms.MessageBoxIcon.Question,
                    defaultButton:
                       System.Windows.Forms.MessageBoxDefaultButton.Button2,
                    options: System.Windows.Forms.MessageBoxOptions.RightAlign |
                       System.Windows.Forms.MessageBoxOptions.RtlReading);

            if (enmResult == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }

            else
            {
                resetForm();
            }
        }

        //*********************************************
        // //حرکت کنترل با کلیدهای کیبورد
        // //کار نمیکند combobox بدلیل وجود
        //
        //private void MainForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    int x = targetPictureBox.Location.X;

        //    int y = targetPictureBox.Location.Y;

        //        if (e.KeyCode == System.Windows.Forms.Keys.Right)
        //        {
        //            x ++;
        //        }
        //        else if (e.KeyCode == System.Windows.Forms.Keys.Left)
        //        {
        //            x --;
        //        }
        //        else if (e.KeyCode == System.Windows.Forms.Keys.Up)
        //        {
        //            y --;
        //        }
        //        else if (e.KeyCode == System.Windows.Forms.Keys.Down)
        //        {
        //            y ++;
        //        }

        //    targetPictureBox.Location = new System.Drawing.Point(x, y);
        
        //}
        //************************************

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            resetForm();
        }

        // با دکمه های برنامه targetPictureBox حرکت
        private void button_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button currentButton;

            //button کردن متغیر به cast 
            currentButton = sender as System.Windows.Forms.Button;

            //button مربوط به left ماکزیمم مقدار 
            int intMaxLeft = mainPanel.Width - targetPictureBox.Width;

            //button مربوط به top ماکزیمم مقدار
            int intMaxTop = mainPanel.Height - targetPictureBox.Height;

            switch (currentButton.Name)
            {
                // کلیک شده یاشد topButton اگر دکمه 
                case "topButton":
                    {
                        //  هنوز داخل محدوده است targetPictureBox و
                        if (targetPictureBox.Top > 0)
                        {
                            //  را یک واحد به بالا انتقال می دهیم targetPictureBox
                            targetPictureBox.Top--;
                        }

                        break;
                    }

                // کلیک شده یاشد rightButton اگر دکمه
                case "rightButton":
                    {
                        //  هنوز داخل محدوده است targetPictureBox و
                        if (targetPictureBox.Left < intMaxLeft)
                        {
                            //  را یک واحد به راست انتقال می دهیم targetPictureBox
                            targetPictureBox.Left++;
                        }

                        break;
                    }

                // کلیک شده یاشد leftButton اگر دکمه
                case "leftButton":
                    {
                        //  هنوز داخل محدوده است targetPictureBox و
                        if (targetPictureBox.Left > 0)
                        {
                            //  را یک واحد به چپ انتقال می دهیم targetPictureBox
                            targetPictureBox.Left--;
                        }

                        break;
                    }

                // کلیک شده یاشد downButton اگر دکمه
                case "downButton":
                    {
                        //  هنوز داخل محدوده است targetPictureBox و
                        if (targetPictureBox.Top < intMaxTop)
                        {
                            //  را یک واحد به پایین انتقال می دهیم targetPictureBox
                            targetPictureBox.Top++;
                        }

                        break;
                    }
                    //اگر هیچ یک از دکمه های فوق کلیک نشده باشد از تابع خارج می شود
                default:
                    break;
            }
        }

    }
}
