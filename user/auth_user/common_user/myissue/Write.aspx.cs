using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class Write : System.Web.UI.Page
{
	article myarticle=new article();
	protected void Page_Load(object sender, EventArgs e)
	{
		if (Session["username"] != null)
		{
			TextBoxAuthor.Text = Session["username"].ToString();
			
		}
		else
		{
			WebMessageBox.Show("sessionʧЧ�������µ�¼","../../../../index.aspx");
		}
	}

    //��������
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
       // SqlConnection myConnection= new SqlConnection("server=.;database=MarriageAndLove;uid=sa;pwd=conan;");
		//string cmdText = "insert into article (username, article_title, article_content, article_date, type_name, type_id) values ('" + Session["username"] + "','"
          //                 + TextBoxTitle.Text + "','" +  "','" + TextareaContent.InnerText+ "','" + DateTime.Now.ToString() + "','" + DropDownListType.SelectedItem.Text + "'," + DropDownListType.SelectedItem.Value + ")";
		myarticle.Username = Session["username"].ToString();
		myarticle.Article_title = TextBoxTitle.Text;
		myarticle.Article_content = TextareaContent.InnerText;
		myarticle.Article_date = DateTime.Now;
		myarticle.Type_name = DropDownListType.SelectedItem.Text;
		myarticle.Type_id = Convert.ToInt32(DropDownListType.SelectedItem.Value);
		if (myarticle.InsertArticle(myarticle) == 0)
		{

		//WebMessageBox.Show("���ӳɹ�");
			//Response.Redirect("myissue.aspx");
			WebMessageBox.Show("���ӳɹ�","myissue.aspx");
		}
		else
		{
			WebMessageBox.Show("����ʧ��");
		}
			
        
    }
}