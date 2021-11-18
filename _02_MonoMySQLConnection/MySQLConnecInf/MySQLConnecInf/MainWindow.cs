/*
 * Author:         Efren Del Real Frias
 * Date:           November 17th 2021
 * FileName:       MainWindow.cs
 * Descripton:     Grafical User interface demo to connect to MySQL Database
 *                 GUI was develop using Gtk on MonoDevelop.
 * 
 */
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
        string connStr = string.Format("server={0};port={1};database={2};user={3};password={4};", txtHost.Text, txtPort.Text, txtDb.Text, txtUser.Text, txtPassword.Text);


        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

        try
        {
        
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                MessageDialog messageBox = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Connection success ;)");
                messageBox.Run();
                messageBox.Destroy();
            }
            else
            {
                MessageDialog messageBox3 = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Timeout :(");
                messageBox3.Run();
                messageBox3.Destroy();

            }
        }
        catch (Exception ex)
        {

            MessageDialog messageBox2 = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Error trying to connect: " + ex.Message);
            messageBox2.Run();
            messageBox2.Destroy();
        }
        finally
        {
            conn.Close();
        }
             
    }
}
