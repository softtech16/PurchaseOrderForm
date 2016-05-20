using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseOrderForm
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
            disable();
            admin_disable(); //if admin is selected
            admin_contact_details(); //list of admin supplier
            cmg_contact_details(); //list of cmg supplier
            department(); //applicable for both
            tower();
            check();
        }
        void disable()
        {
            tbx_po.Enabled = false;
            date.Enabled = false;
            tbx_net.Enabled = false;
            tbx_vat.Enabled = false;
            tbx_vat_inclusive.Enabled = false;
        }
        void admin_disable()
        {
            tbx_pr.Visible = false;
            label2.Visible = false;
            label10.Visible = false;
            tbx_comment.Visible = false;
        }
        void admin_contact_details()
        {
            cmb_supplier.Items.Add("Elite Asia Development Corp.");
            cmb_supplier.Items.Add("Forms International Ent. Corp.");
            cmb_supplier.Items.Add("Gilgian Printing & Corp. Giveaways");
            cmb_supplier.Items.Add("Ink Bright Trading");
            cmb_supplier.Items.Add("Innogen Global Trading");
            cmb_supplier.Items.Add("KVV Trading");
            cmb_supplier.Items.Add("Perfection Packaging Solution");
            cmb_supplier.Items.Add("Premium Graphics Asia Center Inc.");
            cmb_supplier.Items.Add("Square Deal Office Resource Inc.");
            cmb_supplier.Items.Add("Tri-M Vault Specialist");
            cmb_supplier.Items.Add("Triplex Enterprises Inc.");
            cmb_supplier.Items.Add("Willex Printing");
        }

        void cmg_contact_details()
        {
            cmb_supplier.Items.Add("Anako Philippines");
            cmb_supplier.Items.Add("Arrowbond");
            cmb_supplier.Items.Add("Asiana Design");
            cmb_supplier.Items.Add("Astronomy Trading");
            cmb_supplier.Items.Add("Bestank Manufacturing");
            cmb_supplier.Items.Add("Build Your Dreams Adv.");
            cmb_supplier.Items.Add("Chan Bros. Inc.");
            cmb_supplier.Items.Add("Chen Zhang Ent. Corp");
            cmb_supplier.Items.Add("Chichay");
            cmb_supplier.Items.Add("Central Lockwood");
            cmb_supplier.Items.Add("Cobankiat Marketing");
            cmb_supplier.Items.Add("Consolidated Robust Inc.");
            cmb_supplier.Items.Add("Darlie Trading Corporation");
            cmb_supplier.Items.Add("Eastman Ind. Supply");
            cmb_supplier.Items.Add("Emerald Vinyl Corp.");
            cmb_supplier.Items.Add("Evergreeen Manufacturing");
            cmb_supplier.Items.Add("Ever Last Roofing");
            cmb_supplier.Items.Add("Fabric City");
            cmb_supplier.Items.Add("Hengda Dev. Corp");
            cmb_supplier.Items.Add("Hitachi Elevator -1");
            cmb_supplier.Items.Add("Hitachi Elevator - Sales");
            cmb_supplier.Items.Add("Hocheng Phils. Corp.");
            cmb_supplier.Items.Add("Hocheng Phils. Corp. - 1");
            cmb_supplier.Items.Add("Hocheng Phils. Corp. - 2");
            cmb_supplier.Items.Add("Hornitex Phil.");
            cmb_supplier.Items.Add("Kuysen Enterprises Inc.");
            cmb_supplier.Items.Add("Kwyne");
            cmb_supplier.Items.Add("Lec Steel Manufacturing Corp.");
            cmb_supplier.Items.Add("Lifters System Inc.");
            cmb_supplier.Items.Add("Maysan Casting");
            cmb_supplier.Items.Add("Metro Marketing");
            cmb_supplier.Items.Add("Mitsubishi Phils.");
            cmb_supplier.Items.Add("Mitsubishi Phils. - 1");
            cmb_supplier.Items.Add("Multi Line Structures Corp.");
            cmb_supplier.Items.Add("Niagara Electric Corp.");
            cmb_supplier.Items.Add("Omni");
            cmb_supplier.Items.Add("Orion Wire & Cable");
            cmb_supplier.Items.Add("Philips Wire & Cable");
            cmb_supplier.Items.Add("Prestige");
            cmb_supplier.Items.Add("Realiving Design Center Corp.");
            cmb_supplier.Items.Add("Rmr Electric");
            cmb_supplier.Items.Add("Rufass");
            cmb_supplier.Items.Add("Soon Chiong Trading");
            cmb_supplier.Items.Add("Sun Max Trading");
            cmb_supplier.Items.Add("The lift Company");
            cmb_supplier.Items.Add("Trade Up");
            cmb_supplier.Items.Add("Unifield Enterprises Inc.");
            cmb_supplier.Items.Add("United Group");
            cmb_supplier.Items.Add("Wescor Transformer Corp.");
            cmb_supplier.Items.Add("Wilcon Builders Depot");
            cmb_supplier.Items.Add("Grohe");
            cmb_supplier.Items.Add("World Champion Mktg.");
        }
        void department()
        {
            cmb_dept.Items.Add("Admin");
            cmb_dept.Items.Add("Acctg & Fin");
            cmb_dept.Items.Add("Sales & Mktg");
            cmb_dept.Items.Add("CMG");
        }
        void tower()
        {
            cmb_tower.Items.Add("1");
            cmb_tower.Items.Add("2");
            cmb_tower.Items.Add("3");
            cmb_tower.Items.Add("4");
            cmb_tower.Items.Add("5");
            cmb_tower.Items.Add("6");
            cmb_tower.Items.Add("7");
        }
        void check()
        {
            cmb_check.Items.Add("Cash on Delivery");
            cmb_check.Items.Add("Payment Before Delivery");
            cmb_check.Items.Add("Full payment upon delivery");
            cmb_check.Items.Add("upon complete delivery");
            cmb_check.Items.Add("Spot Cash");
            cmb_check.Items.Add("7 days");
            cmb_check.Items.Add("15 days");
            cmb_check.Items.Add("30 Days");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.ShowDialog();
        }

        private void btn_dp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Downpayment downpayment = new Downpayment();
            downpayment.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Item item = new Item();
            item.ShowDialog();
        }

        private void rbtn_adm_CheckedChanged(object sender, EventArgs e)
        {
            disable();
        }
    }
}
