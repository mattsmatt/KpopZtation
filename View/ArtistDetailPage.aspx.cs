using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class ArtistDetailPage : System.Web.UI.Page
    {
        public Artist artistObject = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //KpopZtationDBEntities db = new KpopZtationDBEntities();

            //List<Artist> artistList = (from i in db.Artists select i).ToList();

            //artistTable.DataSource = artistList;
            //artistTable.DataBind();
            int ArtistID = Convert.ToInt32(Request.QueryString["ArtistID"]);
            Debug.Write(ArtistID);
            artistObject = ArtistRepository.getArtistByID(ArtistID);
            string ArtistImage = artistObject.ArtistImage;
            Image1.ImageUrl = "~/Assets/Artist/"+ ArtistImage;
            
        }
    }
}