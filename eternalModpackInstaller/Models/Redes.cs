using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eternalModpackInstaller.Models
{
    public class Redes
    {
        public Facebook Facebook { get; set; }
        public Tiktok tiktok { get; set; }
        public Twitter twitter { get; set; }
        public Youtube youtube { get; set; }
        public Twitch twitch { get; set; }


        public List<Redes> getRedes()
        {

            List<Redes> redes = new List<Redes>
            {
                new Redes {
                    Facebook = this.Facebook,
                    tiktok = this.tiktok,
                    twitter = this.twitter,
                    youtube = this.youtube,
                    twitch = this.twitch,
                },
            };

            return redes;


        }
    }
}
