
namespace game1
{
    /// <summary>
    /// Path of movement class
    /// </summary>
    public class Path
    {
        /// <summary>
        /// Constructor overloaded!
        /// </summary>
        /// <param name="slope of movement along X"> Slope x</param>
        /// <param name="slope of movement along Y"> Slope y</param>
        public Path(int slopeX,int slopeY)
        {
            SlopeX = slopeX;  

            SlopeY = slopeY;

        }

        public int SlopeX;

        public int SlopeY;

        /// <summary>
        /// Get neew slope if need
        /// </summary>
        /// <param name="enemy"> enemyPictureBox</param>
        /// <param name="maxTop">The max of top</param>
        /// <param name="maxLeft"> The max of left</param>


        //   mainPanel  با مرز enemyPictureBox در تابع زیر در صورتیکه
        //دریافت میکندPath برخورد کند شیب جدید به صورت رندوم برای 

        public void checkToGetNewSlope
                (System.Windows.Forms.PictureBox enemy, int maxTop, int maxLeft)
        {
            System.Random generator = new System.Random();

            //اگر به مرز رسیده
            if (enemy.Top == 0)
            {
                //شیب (رندوم ) جدید دریافت می کنیم 
                SlopeX = generator.Next(-10, 10);

                SlopeY = generator.Next(0, 10);
            }
            //اگر به مرز رسیده
            else if (enemy.Left == 0)
            {
                //شیب (رندوم ) جدید دریافت می کنیم
                SlopeX = generator.Next(0, 10);

                SlopeY = generator.Next(-10, 10);
            }
            //اگر به مرز رسیده
            else if (enemy.Top==maxTop)
            {
                //شیب (رندوم ) جدید دریافت می کنیم
                SlopeX = generator.Next(-10,10);

                SlopeY = generator.Next(-10,0);
            }
            //اگر به مرز رسیده
            else if (enemy.Left==maxLeft)
            {
                //شیب (رندوم ) جدید دریافت می کنیم
                SlopeX = generator.Next(-10,0);

                SlopeY = generator.Next(-10,10);

            }

        }

    }
}
