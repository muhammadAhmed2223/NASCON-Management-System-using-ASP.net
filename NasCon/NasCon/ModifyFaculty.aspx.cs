﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class ModifyFaculty : System.Web.UI.Page
{
    public string goodmsg = "";
    public string msg = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string RollNo = TextBox1.Text;
        string Name = TextBox2.Text;
        string Email = TextBox3.Text;
        string Password = TextBox4.Text;

        if (Name == "")
        {
            string q1 = "Select F_Name from Faculty_Mentors where Mentor_ID = '" + RollNo + "'";
            cm = new SqlCommand(q1, conn);
            Name = cm.ExecuteScalar().ToString();
        }

        if (Email == "")
        {
            string q1 = "Select Email from Faculty_Mentors where Mentor_ID = '" + RollNo + "'";
            cm = new SqlCommand(q1, conn);
            Email = cm.ExecuteScalar().ToString();
        }

        if (Password == "")
        {
            string q1 = "Select F_Password from Faculty_Mentors where Mentor_ID = '" + RollNo + "'";
            cm = new SqlCommand(q1, conn);
            Password = cm.ExecuteScalar().ToString();
        }

        string query = "update Faculty_Mentors set F_Name = '" + Name + "', Email = '" + Email + "', F_Password = '" + Password + "' where Mentor_ID = '" + RollNo + "'";

        cm = new SqlCommand(query, conn);

        try
        {
            goodmsg = "Updated Record";
            msg = "";
            cm.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627)
            {
                msg = "Roll Number already exists in record";
                goodmsg = "";
            }
            else
            {
                goodmsg = "";
                msg = "Error occured while updating";
            }
        }

        cm.Dispose();
        conn.Close();
    }
}