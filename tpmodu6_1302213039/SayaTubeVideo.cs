using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodu6_1302213039
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title.Length <= 100 && title != null, "judul video memiliki panjang maksimal 100 karakter dan tidak null.");
            this.title = title;
            var random = new Random();
            this.id = random.Next(0, 5);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 50, "Input penambahan play count maksimal 50 pada setiap panggilan method-nya.");
            try
            {
                this.playCount = checked(this.playCount + playCount);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Overflow exception : " + e.Message);
            }
        }

        public void PrintVideoDetail()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("playCount : " + playCount);
        }
    }
}
