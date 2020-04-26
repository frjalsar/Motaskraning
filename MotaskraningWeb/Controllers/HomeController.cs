using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MotaskraningWeb.Models;
using Newtonsoft.Json;

namespace MotaskraningWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Domari> Domarar = NaIDomara();
            List<Grein> Greinar = NaIGreinar();
            List<string> Haldarar = NaIMotshaldara();
            List<TextValueHolder> Stadsetningar = NaIStadsetningar();

            MotaskraningModel model = new MotaskraningModel();

            model.Domarar = Domarar;
            model.Greinar = Greinar;
            model.skraning = new Skraning();



            List<SelectListItem> listi = new List<SelectListItem>();
            foreach (Domari dom in Domarar)
            {
                listi.Add(new SelectListItem()
                {
                    Text = dom.nafn,
                    Value = dom.nafn
                });
            }
            SelectList val = new SelectList(listi, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi2 = new List<SelectListItem>();
            foreach (string dom in Haldarar)
            {
                listi2.Add(new SelectListItem()
                {
                    Text = dom,
                    Value = dom
                });
            }
            SelectList val2 = new SelectList(listi2, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi3 = new List<SelectListItem>();
            foreach (TextValueHolder dom in Stadsetningar)
            {
                listi3.Add(new SelectListItem()
                {
                    Text = dom.Text, // dom,
                    Value = dom.Value // dom
                });
            }
            SelectList val3 = new SelectList(listi3, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi4 = new List<SelectListItem>();
            foreach (Grein dom in Greinar)
            {
                listi4.Add(new SelectListItem()
                {
                    Text = dom.nafnGreinar,
                    Value = dom.nafnGreinar
                });
            }
            SelectList val4 = new SelectList(listi4, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            ViewBag.CityList = val;
            ViewBag.CityList2 = val2;
            ViewBag.CityList3 = val3;
            ViewBag.CityList4 = val4;

            return View(model);
        }

        /*public IActionResult Motaskraning()
        {
            List<Domari> Domarar = NaIDomara();
            List<Grein> Greinar = NaIGreinar();
            List<string> Haldarar = NaIMotshaldara();
            List<string> Stadsetningar = NaIStadsetningar();

            MotaskraningModel model = new MotaskraningModel();

            model.Domarar = Domarar;
            model.Greinar = Greinar;
            model.skraning = new Skraning();

            

            List<SelectListItem> listi = new List<SelectListItem>();
            foreach (Domari dom in Domarar)
            {
                listi.Add(new SelectListItem()
                {
                    Text = dom.nafn,
                    Value = dom.nafn
                });
            }
            SelectList val = new SelectList(listi, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi2 = new List<SelectListItem>();
            foreach (string dom in Haldarar)
            {
                listi2.Add(new SelectListItem()
                {
                    Text = dom,
                    Value = dom
                });
            }
            SelectList val2 = new SelectList(listi2, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi3 = new List<SelectListItem>();
            foreach (string dom in Stadsetningar)
            {
                listi3.Add(new SelectListItem()
                {
                    Text = dom,
                    Value = dom
                });
            }
            SelectList val3 = new SelectList(listi3, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi4 = new List<SelectListItem>();
            foreach (Grein dom in Greinar)
            {
                listi4.Add(new SelectListItem()
                {
                    Text = dom.nafnGreinar,
                    Value = dom.nafnGreinar
                });
            }
            SelectList val4 = new SelectList(listi4, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            ViewBag.CityList = val;
            ViewBag.CityList2 = val2;
            ViewBag.CityList3 = val3;
            ViewBag.CityList4 = val4;

            return View(model);
        }*/

        [HttpPost]
        public ActionResult Index(MotaskraningModel empmodel)
        {
            // Gera eithvað við upplýsingarnar
            // Kalla á SendToJira fall með upplýsingunum úr epmodel

            string upplysingar = empmodel.skraning.motshaldari + ";" + empmodel.skraning.stadsetning + ";" + empmodel.skraning.domari;
            if(empmodel.Greinar != null) { 
                foreach(var grein in empmodel.Greinar)
                {
                    upplysingar += ";" + grein.gerdGreinar + ";" + grein.nafnGreinar;
                }
            }
            fieldHolder JiraDot = new fieldHolder();

            fields fields = new fields();

            Project verkefni = new Project();
            verkefni.key =  "PRUFA";
            fields.project = verkefni;

            fields.summary = "Prufa frá Motaskraningarforriti.";

            fields.description = upplysingar;

            Issuetype issType = new Issuetype();
            issType.name = "Task";

            fields.issuetype = issType;

            Assignee assignee = new Assignee();
            assignee.name = "jira-software-users";

            fields.assignee = assignee;

            JiraDot.fields = fields;

            SendToJira(JiraDot);

            // Ná í og skila upphafsupplýsingum
            /*List<Domari> Domarar = NaIDomara();

            List<Grein> Greinar = NaIGreinar();

            MotaskraningModel model = new MotaskraningModel();

            model.Domarar = Domarar;
            model.Greinar = Greinar;
            model.skraning = new Skraning();

            List<SelectListItem> listi = new List<SelectListItem>();

            foreach (Domari dom in Domarar)
            {
                listi.Add(new SelectListItem()
                {
                    Text = dom.nafn,
                    Value = dom.nafn
                });
            }

            SelectList val = new SelectList(listi, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            ViewBag.CityList = val;*/


            List<Domari> Domarar = NaIDomara();
            List<Grein> Greinar = NaIGreinar();
            List<string> Haldarar = NaIMotshaldara();
            List<TextValueHolder> Stadsetningar = NaIStadsetningar();

            MotaskraningModel model = new MotaskraningModel();

            model.Domarar = Domarar;
            model.Greinar = Greinar;
            model.skraning = new Skraning();



            List<SelectListItem> listi = new List<SelectListItem>();
            foreach (Domari dom in Domarar)
            {
                listi.Add(new SelectListItem()
                {
                    Text = dom.nafn,
                    Value = dom.nafn
                });
            }
            SelectList val = new SelectList(listi, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi2 = new List<SelectListItem>();
            foreach (string dom in Haldarar)
            {
                listi2.Add(new SelectListItem()
                {
                    Text = dom,
                    Value = dom
                });
            }
            SelectList val2 = new SelectList(listi2, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi3 = new List<SelectListItem>();
            foreach (TextValueHolder dom in Stadsetningar)
            {
                listi3.Add(new SelectListItem()
                {
                    Text = dom.Text,
                    Value = dom.Value
                });
            }
            SelectList val3 = new SelectList(listi3, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi4 = new List<SelectListItem>();
            foreach (Grein dom in Greinar)
            {
                listi4.Add(new SelectListItem()
                {
                    Text = dom.nafnGreinar,
                    Value = dom.nafnGreinar
                });
            }
            SelectList val4 = new SelectList(listi4, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            ViewBag.CityList = val;
            ViewBag.CityList2 = val2;
            ViewBag.CityList3 = val3;
            ViewBag.CityList4 = val4;

            return View(model);
        }

        public ActionResult AddChild()
        {
            List<Domari> Domarar = NaIDomara();
            List<Grein> Greinar = NaIGreinar();
            List<string> Haldarar = NaIMotshaldara();
            List<TextValueHolder> Stadsetningar = NaIStadsetningar();

            MotaskraningModel model = new MotaskraningModel();

            model.Domarar = Domarar;
            model.Greinar = Greinar;
            model.skraning = new Skraning();



            List<SelectListItem> listi = new List<SelectListItem>();
            foreach (Domari dom in Domarar)
            {
                listi.Add(new SelectListItem()
                {
                    Text = dom.nafn,
                    Value = dom.nafn
                });
            }
            SelectList val = new SelectList(listi, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi2 = new List<SelectListItem>();
            foreach (string dom in Haldarar)
            {
                listi2.Add(new SelectListItem()
                {
                    Text = dom,
                    Value = dom
                });
            }
            SelectList val2 = new SelectList(listi2, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi3 = new List<SelectListItem>();
            foreach (TextValueHolder dom in Stadsetningar)
            {
                listi3.Add(new SelectListItem()
                {
                    Text = dom.Text,
                    Value = dom.Value
                });
            }
            SelectList val3 = new SelectList(listi3, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            List<SelectListItem> listi4 = new List<SelectListItem>();
            foreach (Grein dom in Greinar)
            {
                listi4.Add(new SelectListItem()
                {
                    Text = dom.nafnGreinar,
                    Value = dom.nafnGreinar
                });
            }
            SelectList val4 = new SelectList(listi4, "Value", "Text"); // (Greinar, "nafnGreinar", "gerdGreinar");

            ViewBag.CityList = val;
            ViewBag.CityList2 = val2;
            ViewBag.CityList3 = val3;
            ViewBag.CityList4 = val4;

            return PartialView("_Grein", new Grein());
        }

        public List<Domari> NaIDomara()
        {
            List<Domari> domarar = new List<Domari>();

            string url = "https://api.fri.is/judges";
            var res = GetFunction(url);
            var judges = JsonConvert.DeserializeObject<List<Judge>>(res);

            for (int i = 0; i < judges.Count; i++)
            {
                Domari dommi = new Domari();
                dommi.nafn = judges[i].fullname;
                domarar.Add(dommi);
            }

            return (domarar);
        }

        public List<TextValueHolder> NaIStadsetningar()
        {
            List<TextValueHolder> stadsetningar = new List<TextValueHolder>();
            
            string url = "https://api.fri.is/venues";
            var res = GetFunction(url);
            var places = JsonConvert.DeserializeObject<List<venue>>(res);

            for (int i = 0; i < places.Count; i++)
            {
                string strengurinn = "";
                if(places[i].indoor == false)
                {
                    strengurinn = places[i].fullName + ";úti";
                } else if (places[i].indoor == true)
                {
                    strengurinn = places[i].fullName + ";inni";
                }

                TextValueHolder stadsetning = new TextValueHolder();
                stadsetning.Text = places[i].fullName;
                stadsetning.Value = strengurinn;

                stadsetningar.Add(stadsetning);
            }

            return (stadsetningar);
        }

        public List<string> NaIMotshaldara()
        {
            string url = "https://api.fri.is/clubs";
            var res = GetFunction(url);
            var klubbar = JsonConvert.DeserializeObject<List<club>>(res);

            List<string> haldarar = new List<string>();

            for(int i = 0; i < klubbar.Count; i++)
            {
                haldarar.Add(klubbar[i].fullName);
            } 

            /*haldarar.Add("Fh");
            haldarar.Add("ÍR");
            haldarar.Add("Breiðablik");*/

            return (haldarar);
        }

        public List<Grein> NaIGreinar()
        {
            string url = "https://api.fri.is/thor/events";
            var res = GetFunction(url);
            var greinar = JsonConvert.DeserializeObject<List<events>>(res);

            List<Grein> Greinar = new List<Grein>();

            for (int i = 0; i < greinar.Count; i++)
            {
                string samsettur = greinar[i].CompoundKey;
                string[] splittadur = samsettur.Split(";");
                string heildarstrengur = splittadur[0] + ";";
                if (splittadur[1] == "1")
                {
                    heildarstrengur += "kvenna;" + splittadur[2] + ";";
                }
                else
                {
                    heildarstrengur += "karla;" + splittadur[2] + ";";
                }
                if (splittadur[3] == "0")
                {
                    heildarstrengur += "úti";
                }
                else
                {
                    heildarstrengur += "inni";
                }


                /*if (greinar[i].Gender == 1)
                {
                    samsettur += "|kvenna";
                }
                else
                {
                    samsettur += "|karla";
                }*/
                Grein a = new Grein();
                a.nafnGreinar = heildarstrengur; // greinar[i].Id;
                Greinar.Add(a);
            }

            
            /*
            Grein grein = new Grein();
            grein.nafnGreinar = "200m";
            grein.gerdGreinar = "hlaup";
            Greinar.Add(grein);
            Grein grein2 = new Grein();
            grein2.nafnGreinar = "400m";
            grein2.gerdGreinar = "hlaup";
            Greinar.Add(grein2);*/

            return Greinar;
        }

        public async void SendToJira(fieldHolder JiraDot)
        {
            HttpClient client = new HttpClient();
            var authString = Convert.ToBase64String(Encoding.UTF8.GetBytes("steini.tki@gmail.com:gqT1nhsuiSAb8zVsTk3975BC"));

            string jsonString = System.Text.Json.JsonSerializer.Serialize(JiraDot);
            // string strengur = "";

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authString);
            var response = await client.PostAsync("https://steini.atlassian.net/rest/api/2/issue/", new StringContent(jsonString, Encoding.UTF8, "application/json"));

            // client.PostAsync(uri, new StringContent(jsonInString, Encoding.UTF8, "application/json"));

            return;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public static string GetFunction(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
