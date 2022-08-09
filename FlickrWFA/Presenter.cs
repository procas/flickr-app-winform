using FlickrWFA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickrWFA
{
    public class Presenter
    {
        public IView View { get; set; }
        public Presenter(IView view)
        {
            View = view;
            view.htmlString = "<!DOCTYPE html><html style=\"background-color:#99B4D1\"><table><tr><td><img src=\"https://live.staticflickr.com/65535/52270866922_c83d527736_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52272095154_4e4090b06d_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52272322690_61ce93661d_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52271831146_d5c78d9c7d_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52271854033_419614bfd4_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> </tr><tr><td><img src=\"https://live.staticflickr.com/65535/52271852548_8c91cb1709_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52270867317_374fc902ed_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52271831541_42ac88884f_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52272005119_c83f5c597a_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52270775982_6c81cd8af5_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> </tr><tr><td><img src=\"https://live.staticflickr.com/65535/52270773717_b2a6c89869_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52272217365_113d096b18_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52271733331_3f254ca5ce_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52271743216_fa6310bd59_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52271748133_e9d66f4b3e_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> </tr><tr><td><img src=\"https://live.staticflickr.com/65535/52272218310_d727a464ce_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52270760487_b25e430df3_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52271725211_43f4286eaa_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52270774132_9cd7c5275e_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52270784202_07582a3e17_m.jpg\" alt=\"red\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> </tr></table></html>";
        }
    }
}
