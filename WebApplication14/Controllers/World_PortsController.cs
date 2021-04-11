using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication14.ViewModels;
using Newtonsoft.Json.Linq;
namespace WebApplication14.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class World_PortsController : ControllerBase
    {


        [HttpGet("info")]

        public ActionResult<Ports> GetPort(int id)
        {
            Ports port = new Ports();
            try
            {
                using (var db = new World_Ports_DBContext())
                {
                    port = db.ResultsPortInformations.Select(spt => new Ports
                    {
                        ID = Convert.ToInt32(spt.IndexNumber),
                        Name = spt.PortName,
                        Country = spt.Country,
                        Port_Latitude = Convert.ToDouble(spt.PortLatitude),
                        Port_Longitude = Convert.ToDouble(spt.PortLongitude)
                    }).Where(p => p.ID == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return port;
        }

        [HttpGet("info")]

        public ActionResult<Ports> GetPortName(string name)
        {
            Ports port = new Ports();

            try
            {
                using (var db = new World_Ports_DBContext())
                {
                    port = db.ResultsPortInformations.Select(spt => new Ports
                    {
                        ID = Convert.ToInt32(spt.IndexNumber),
                        Name = spt.PortName,
                        Country = spt.Country,
                        Port_Latitude = Convert.ToDouble(spt.PortLatitude),
                        Port_Longitude = Convert.ToDouble(spt.PortLongitude)


                    }).Where(p => p.Name == name).FirstOrDefault();
                }

            }

            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return port;



        }

        [HttpGet("info")]
        public ActionResult<Ports> GetThePort(double latitude, double longitude)
        {
            //latitude = 11.6;
            //longitude = 43.083333;  
            Ports port = new Ports();

            try
            {

                using (var db = new World_Ports_DBContext())
                {
                    port = db.ResultsPortInformations.Select(st => new Ports
                    {
                        ID = Convert.ToInt32(st.IndexNumber),
                        Name = st.PortName,
                        Country = st.Country,
                        Port_Latitude = Convert.ToDouble(st.PortLatitude),
                        Port_Longitude = Convert.ToDouble(st.PortLongitude)
                    }).OrderBy(sp => Math.Pow((sp.Port_Latitude - latitude), 2) + Math.Pow((sp.Port_Longitude - longitude), 2)).First();


                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return port;



        }

        [HttpGet("info")]
        public ActionResult<List<GetPortsColumnsSpecial>> GetPortsInRectangle(string xMax, string yMax, string xMin, string yMin)
        {

            string ProcedureConnection = "EXEC Ports " + "@xMax=" + xMax + "," + "@yMax=" + yMax + "," +
                                                     "@xMin=" + xMin + "," + "@yMin=" + yMin;



            using (var db = new World_Ports_DBContext())
            {

                var World_Ports = db.GetPortsColumnsSpecials.FromSqlRaw(ProcedureConnection, xMax, yMax, xMin, yMin).ToList();



                return World_Ports;
            }





        }

    }



}
