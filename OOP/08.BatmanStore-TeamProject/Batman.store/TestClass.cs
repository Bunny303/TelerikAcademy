using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batman.store
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Article someTV = new TV("samsung", "some model", 1000M, 5, "metal", new VideoFormat[] { VideoFormat.mov, VideoFormat.wmv }, new Display(65000, 32f));
            Article someMonitor = new Monitor("Philips", "philips model", 950M, 2, true, new VideoFormat[] { VideoFormat.wmv, VideoFormat.mp4, VideoFormat.asf }, new Display(2000000, 46.4f));
            Article someTV2 = new TV("samsung", "some model", 1000M, 5, "metal", new VideoFormat[] { VideoFormat.mov, VideoFormat.wmv }, new Display(65000, 32f));
            // Не трябва ли да се съдава taka?
            // TV someTV = new TV("samsung", "some model", 1000M, 5, "metal", new VideoFormat[] { VideoFormat.mov, VideoFormat.wmv }, new Display(65000, 32f));
            // ако се създават от тип IVideoPlayable, тогава трябва Article: IVideoPlayable, иначе не може Store да ги добавя.
            // stava i s Article, просто направих няколко инстанции за да тествам класовете : ), see above  : )


            List<Article> videoArticles = new List<Article>()
            {
                someTV,
                someMonitor,
                someTV2,
            };

            //showing the interface IVideoPlayable
            //the result will be null if can't cast
            foreach (var item in videoArticles)
            {
                var Videoitem = item as IVideoPlayable;
            }

            TV testTV = new TV("Philips", "567", 530m, 3, "pink", new VideoFormat[] { VideoFormat.mov, VideoFormat.wmv }, new Display(65000, 32f));
            Monitor testMonitor = new Monitor("Philips", "2343", 950M, 1, true, new VideoFormat[] { VideoFormat.wmv, VideoFormat.mp4, VideoFormat.asf }, new Display(2000000, 46.4f));

            Store.Instance.Load(testTV);
            Store.Instance.Load(testTV);
            Store.Instance.Load(testMonitor);
            Store.Instance.Load(someTV);
            Store.Instance.Load(someMonitor);
            Store.Instance.Load(someTV2);
            Store.Instance.Sell("TV", "567");
            Store.Instance.Sell("Monitor", "2343");
            Store.Instance.ShowAllPromotions();

            Article myMp3 = new MP3Player("Philips", "ZDX-12S", 125.67M, 10, 4, new SoundFormat[] { SoundFormat.MPEG4, SoundFormat.МP3, SoundFormat.WMV },
               new Display(125, 12.5f), new Frequency(20, 240), 35);
            Article myAmplifier = new Amplifier("Harman Cardon", "123", 125.67M, 10, true, 5, 6);
            Article mySpeakers = new Speakers("Sony", "Bass23F", 123m, 11, 12, 95, new Frequency(20, 120), 40);

            List<Article> audioArticles = new List<Article>()
            {
                myMp3,
                myAmplifier,
                mySpeakers
            };

            //showing the interface IVideoPlayable
            //the result will be null if can't cast
            foreach (var item in audioArticles)
            {
                var audioItem = item as ISoundable;
                Store.Instance.Load(item);
            }

            //creating instance of HomeTheatre

            Article TelerikTheatre = new HomeTheatre("Telerik", "Academy", 5468.39m, 1, new Frequency(20, 150), 500,
                new VideoFormat[] { VideoFormat.mp4, VideoFormat.asf }, new Display(543, 42f), myAmplifier as Amplifier, 
                new Speakers[] { mySpeakers as Speakers, mySpeakers as Speakers }, someTV as TV,
                new DvdPlayer("JVC", "12CRX-12", 123.45m, 1, new Dimensions(1023, 842, 23), new VideoFormat[] { VideoFormat.mp4, VideoFormat.asf }, new Display(65000, 32f)) 
                );

            Store.Instance.Load(TelerikTheatre);
            //showing all promotions including audioArticles now :)
            Store.Instance.ShowAllPromotions();

            //getting the current quantity of myMp3
            Store.Instance.GetQuantity(myMp3);
            //adding more myMp3
            Store.Instance.Load(myMp3);
            Store.Instance.GetQuantity(myMp3);
            //selling mp3player so the quantity is decreasing
            Store.Instance.Sell("MP3Player", "ZDX-12S");
            Store.Instance.GetQuantity(myMp3);
        }
    }
}
