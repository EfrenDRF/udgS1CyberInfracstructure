using System;
using Gtk;
using System.Data;
using MySql.Data.MySqlClient;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void btn_TestConnection_Click(object sender, EventArgs e)
    {


    }
}
