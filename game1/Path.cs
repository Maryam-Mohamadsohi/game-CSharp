
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
        /// <param name="slopex"> Slope x</param>
        /// <param name="slopey"> Slope y</param>
        public Path(int slopex,int slopey)
        {
            SlopeX = slopex;

            SlopeY = slopey;

        }

        public int SlopeX;

        public int SlopeY;

        /// <summary>
        /// Get neew slope if need
        /// </summary>
        /// <param name="enemy"> enemyPictureBox</param>
        /// <param name="maxTop">The max of top</param>
        /// <param name="maxLeft"> The max of left</param>
        public void checkToGetNewSlope(System.Windows.Forms.PictureBox enemy,int maxTop,int maxLeft)
        {
            System.Random generator = new System.Random();

            if (enemy.Top==0)
            {
                SlopeX = generator.Next(-10,0);

                SlopeY = generator.Next(0, 10);
            }
            else if(enemy.Left==0)
            {
                SlopeX= generator.Next(0, 10);

                SlopeY = generator.Next(0, 10);
            }
            else if (enemy.Top==maxTop)
            {
                SlopeX = generator.Next(0,10);

                SlopeY = generator.Next(-10,0);
            }
            else if (enemy.Left==maxLeft)
            {
                SlopeX = generator.Next(-10,0);

                SlopeY = generator.Next(0,10);

            }

        }

    }
}
