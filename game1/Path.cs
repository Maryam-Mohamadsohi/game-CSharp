
namespace game1
{
    /// <summary>
    /// کلاس مسیر حرکت
    /// </summary>
    public class Path
    {
        /// <summary>
        /// Constructor overloaded!
        /// </summary>
        /// <param name="slopeX">x شیب</param>
        /// <param name="slopeY">y شیب</param>
        public Path(int slopeX,int slopeY)
        {
            SlopeX = slopeX;  

            SlopeY = slopeY;
        }

        /// <summary>
        ///x شیب 
        /// </summary>
        public int SlopeX { get; set; }

        /// <summary>
        ///y شیب 
        /// </summary>
        public int SlopeY { get; set; }
        
        /// <summary>
        ///دریافت شیب درصورت لزوم
        /// </summary>
        /// <param name="enemy"> enemyPictureBox</param>
        /// <param name="maxTop">The max of top</param>
        /// <param name="maxLeft"> The max of left</param>
        public void CheckToGetNewSlope
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
