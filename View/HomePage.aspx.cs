using KpopZtation.Controller;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        public List<Artist> artistList = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            KpopZtationDBEntities db = new KpopZtationDBEntities();

            artistList = (from i in db.Artists select i).ToList();

            artistTable.DataSource = artistList;
            artistTable.DataBind();
        }

        protected void artistTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = "Admin";
            if (role.Equals("Admin"))
            {
                int selectedArtistID = int.Parse(artistTable.SelectedRow.Cells[1].Text);
                Artist artist = ArtistRepository.getArtistByID(selectedArtistID);
                TxtSelectedArtistID.Text = artist.ArtistID.ToString();
                TxtSelectedArtistName.Text = artist.ArtistName;
            }
            else if (role.Equals("Customer"))
            {
                string id = artistTable.SelectedRow.Cells[1].Text;
                Response.Redirect("ArtistDetailPage.aspx?id=" + id);
            }

        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            LblError.ForeColor = System.Drawing.Color.Red;

            string id = TxtSelectedArtistID.Text;
            string artistName = TxtSelectedArtistName.Text;
            int errorNum = ArtistController.deleteArtist(id, artistName);
            if (errorNum == 0)
            {
                LblError.Text = "Artist ID and Artist name cannot be empty";
            }
            else if (errorNum == 1)
            {
                LblError.Text = "There is no artist with id: " + id;
            }
            else if (errorNum == 2)
            {
                LblError.Text = "There is no artist with the name: " + artistName;
            }
            else if (errorNum == 3)
            {
                LblError.Text = "There is no artist with id: " + id + " with the name: " + artistName;
            }
            else if (errorNum == 4)
            {
                LblError.ForeColor = System.Drawing.Color.Green;
                LblError.Text = "Deletion Successful";
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertArtistPage.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            // bikin validasi kalo belom di select
            string id = artistTable.SelectedRow.Cells[1].Text;
            if (id.Equals(""))
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Response.Redirect("UpdateArtistPage.aspx?id=" + id);
            }
        }

        protected void artistTable_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = artistTable.Rows[e.RowIndex];
            int ArtistID = int.Parse(row.Cells[1].Text);

            Response.Redirect("~/View/ArtistDetailPage.aspx?ArtistID=" + ArtistID);
        }

        public void GetImageUrl(Artist item)
        {
            Image1.ImageUrl = "~/Assets/Artist/" + item.ArtistImage;
        }
    }
}