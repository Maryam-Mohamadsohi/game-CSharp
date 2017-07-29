

namespace game1
{
    public partial class MainForm : System.Windows.Forms.Form
    {

        public Path Path1 = new Path(5,2);

        public Path Path2 = new Path(-3, 4);

        public Path Path3 = new Path(1, -5);

        public Path Path4 = new Path(-5, -6);


        public MainForm()
        {
            InitializeComponent();

        }

        protected override bool ProcessDialogKey(System.Windows.Forms.Keys keyData)
        {
            this.MoveControlByKeys(keyData, targetPictureBox);

            return base.ProcessDialogKey(keyData);
        }

        // با دکمه های کیبورد targetPictureBox حرکت

        private void MoveControlByKeys(System.Windows.Forms.Keys keyData,
                            System.Windows.Forms.Control control)

        {
            if (keyData == System.Windows.Forms.Keys.Left)
            {
                if (control.Location.X > 0)
                {
                    control.Location = new System.Drawing.Point
                             (control.Location.X - 1, control.Location.Y);
                }
            }
            else if (keyData == System.Windows.Forms.Keys.Right)
            {
                if (control.Location.X <
                                mainPanel.Width - control.Width)
                {
                    control.Location = new System.Drawing.Point
                            (control.Location.X + 1, control.Location.Y);
                }
            }
            else if (keyData == System.Windows.Forms.Keys.Up)
            {
                if (control.Location.Y > 0)
                {
                    control.Location = new System.Drawing.Point
                            (control.Location.X, control.Location.Y - 1);
                }
            }
            else if (keyData == System.Windows.Forms.Keys.Down)
            {
                if (control.Location.Y <
                                 mainPanel.Height - control.Height)
                {
                    control.Location = new System.Drawing.Point
                            (control.Location.X, control.Location.Y + 1);
                }
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {

            // دکمه غیر فعال وبازی شروع می شود goButton با زدن دکمه

            if (goButton.Enabled)
            {

                return;       //  هنوز بازی شروع نشده 
            }

            string strLevel = levelComboBox.Text;     // فعالenemyPitureBox تعداد

            switch (strLevel)
            {
                case "4":
                    {
                        if (CheckAccident(enemyPictureBox4) == false)
                        {
                            MoveEnemy(enemyPictureBox4, Path4);

                            Path4.checkToGetNewSlope(enemyPictureBox4,
                                maxTop: mainPanel.Height - enemyPictureBox4.Height,
                                    maxLeft: mainPanel.Width - enemyPictureBox4 .Width);

                        }

                        goto case "3";
                    }
                case "3":
                    {
                        if (CheckAccident(enemyPictureBox3) == false)
                        {
                            MoveEnemy(enemyPictureBox3, Path3);

                            Path3.checkToGetNewSlope(enemyPictureBox3,
                                maxTop: mainPanel.Height - enemyPictureBox3.Height,
                                    maxLeft: mainPanel.Width - enemyPictureBox3.Width);

                        }

                        goto case "2";
                    }
                case "2":
                    {
                        if (CheckAccident(enemyPictureBox2) == false)
                        {
                            MoveEnemy(enemyPictureBox2, Path2);

                            Path2.checkToGetNewSlope(enemyPictureBox2,
                                maxTop: mainPanel.Height - enemyPictureBox2.Height,
                                    maxLeft: mainPanel.Width - enemyPictureBox2.Width);

                        }

                        goto case "1";
                    }

                case "1":
                    {
                        if (CheckAccident(enemyPictureBox1) == false)
                        {
                            MoveEnemy(enemyPictureBox1,Path1);

                            Path1.checkToGetNewSlope(enemyPictureBox1,
                                maxTop:mainPanel.Height-enemyPictureBox1.Height,
                                    maxLeft:mainPanel.Width-enemyPictureBox1.Width);

                        }

                        break;
                    }
            }
        }

        public void MoveEnemy(System.Windows.Forms.PictureBox enemy,Path path)
        {
            if (path.SlopeX<0)
            {
                enemy.Left = 
                    System.Math.Max(0, enemy.Left + path.SlopeX);

            }
            else
            {
                enemy.Left = 
                    System.Math.Min(mainPanel.Width-enemy.Width, enemy.Left + path.SlopeX);
            }

            if (path.SlopeY< 0)
            {
                enemy.Top =
                    System.Math.Max(0, enemy.Top + path.SlopeY);

            }
            else
            {
                enemy.Top =
                    System.Math.Min(mainPanel.Height - enemy.Height, enemy.Top + path.SlopeY);
            }
        }

        //برمیگرداند وپیغام می دهد True درصورت برخورد تابع مقدار 

        public bool CheckAccident(System.Windows.Forms.PictureBox enemyPictureBox)
        {
            bool boolVerticalAccident = false;

            bool boolHorizentalAccident = false;

            int intWidthBound =
                (enemyPictureBox.Width + targetPictureBox.Width) / 2;

            int intHeightBound =
                (enemyPictureBox.Height + targetPictureBox.Height) / 2;

            if (System.Math.Abs(targetPictureBox.Left - enemyPictureBox.Left)
                        <= intWidthBound)
            {
                boolHorizentalAccident = true;
            }

            if (System.Math.Abs(targetPictureBox.Top - enemyPictureBox.Top)
                        <= intHeightBound)
            {
                boolVerticalAccident = true;

            }

            if (boolVerticalAccident && boolHorizentalAccident)
            {
                timer1.Enabled = false;

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

            startGroupBox.Enabled = true;

            arrowKeyGroupBox.Enabled = false;

            timer1.Enabled = false;

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

        // دکمه غیر فعال وبازی شروع می شود goButton با زدن دکمه

        private void goButton_Click(object sender, System.EventArgs e)
        {

            startGroupBox.Enabled = false;

            arrowKeyGroupBox.Enabled = true;

            timer1.Enabled = true;

        }

        // فعالenemyPitureBox تعیین تعداد

        private void levelComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int intLevel = System.Convert.ToInt32(levelComboBox.Text);

            switch (intLevel)
            {
                case 1:
                    {
                        enemyPictureBox2.Visible = false;

                        enemyPictureBox3.Visible = false;

                        enemyPictureBox4.Visible = false;

                        resetForm();

                        break;
                    }

                case 2:
                    {
                        enemyPictureBox2.Visible = true;

                        enemyPictureBox3.Visible = false;

                        enemyPictureBox4.Visible = false;

                        resetForm();

                        break;
                    }
                case 3:
                    {
                        enemyPictureBox2.Visible = true;

                        enemyPictureBox3.Visible = true;

                        enemyPictureBox4.Visible = false;

                        resetForm();

                        break;
                    }
                case 4:
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

        // //کار نمیکند combobox بدلیل وجود

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

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            resetForm();
        }

        // با دکمه های برنامه targetPictureBox حرکت

        private void button_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button currentButton;

            currentButton = sender as System.Windows.Forms.Button;

            int intMaxLeft = mainPanel.Width - targetPictureBox.Width;

            int intMaxTop = mainPanel.Height - targetPictureBox.Height;

            switch (currentButton.Name)
            {
                case "topButton":
                    {

                        if (targetPictureBox.Top > 0)
                        {
                            targetPictureBox.Top--;
                        }

                        break;
                    }

                case "rightButton":
                    {
                        if (targetPictureBox.Left < intMaxLeft)
                        {
                            targetPictureBox.Left++;
                        }

                        break;
                    }

                case "leftButton":
                    {
                        if (targetPictureBox.Left > 0)
                        {
                            targetPictureBox.Left--;
                        }

                        break;
                    }

                case "downButton":
                    {
                        if (targetPictureBox.Top < intMaxTop)
                        {
                            targetPictureBox.Top++;
                        }

                        break;
                    }

                default:
                    break;
            }
        }

    }
}
