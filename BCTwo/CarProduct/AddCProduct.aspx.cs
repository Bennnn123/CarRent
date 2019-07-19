using BCTwo.WFClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCTwo.CarProduct
{
    public partial class AddCProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
            CProduct cp = new CProduct()
            {
                Name = txtName.Text,
                Brand = DList1.Text,
                Category = txtCate.Text,
                Modal = DList2.Text,
                Stock = txtStock.Text,
                Price = int.Parse(txtPrice.Text),
                Description = txtDesc.Text,
                Passengers = DList3.Text
            };

            if (FileUpload1.HasFile)
            {
                
                foreach (var postedFile in FileUpload1.PostedFiles)
                {
                    

                    string fileName = Path.GetFileName(postedFile.FileName);
                    postedFile.SaveAs(Server.MapPath("~/FileImage/") + fileName);
                }

                //filName
               
            }
        }
    }
    

}