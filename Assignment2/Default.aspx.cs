using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] events = new string[5,2];
    protected void Page_Load(object sender, EventArgs e)
    {
        events[0,0]= "4/8/2017";
        events[0, 1] = "Tea Party";
        events[1, 0] = "4/10/2017";
        events[1, 1] = "TV Show";
        events[2, 0] = "4/8/2017";
        events[2, 1] = "Movie Night";
        events[3, 0] = "4/16/2017";
        events[3, 1] = "Chinese Food Night";
        events[4, 0] = "4/23/2017";
        events[4, 1] = "Japanese Movie Night";
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        string myDate = Calendar1.SelectedDate.ToShortDateString();

        Label1.Text = "";

        for(int i = 0; i < 5; i++)
        {
            if (myDate.Equals(events[i,0]))
            {
                Label1.Text += events[i, 1] + "<br />";
            }
        }

    }
}