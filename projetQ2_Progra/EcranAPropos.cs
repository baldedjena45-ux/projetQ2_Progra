using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetQ2_Progra
{
    public partial class EcranAPropos : Form
    {
        
        private Cursor _curseurOriginalForm;
        private Cursor _curseurOriginalControl;
        private Cursor _curseurPerso; 

        public EcranAPropos()
        {
            InitializeComponent();

            
            _curseurOriginalForm = this.Cursor;

            
             try
             {
                 _curseurPerso = new Cursor(Application.StartupPath + "\\note.cur.ico");
             }
             catch
             {
                 _curseurPerso = null;
             }
            

            panelCadre.MouseEnter += Panel_MouseEnter;
            panelCadre.MouseLeave += Panel_MouseLeave;

            btnConfirmer.MouseEnter += Btn_MouseEnter;
            btnConfirmer.MouseLeave += Btn_MouseLeave;
        }

        
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            panelCadre.BackColor = Color.Gainsboro;

            _curseurOriginalControl = this.Cursor;
            this.Cursor = _curseurPerso ?? Cursors.Hand;
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            panelCadre.BackColor = SystemColors.Control;

            this.Cursor = _curseurOriginalControl;
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmer.BackColor = Color.LightSteelBlue;
            btnConfirmer.Font = new Font(btnConfirmer.Font, FontStyle.Bold);

            _curseurOriginalControl = this.Cursor;
            this.Cursor = _curseurPerso ?? Cursors.UpArrow;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmer.BackColor = SystemColors.Control;
            btnConfirmer.Font = new Font(btnConfirmer.Font, FontStyle.Regular);

            this.Cursor = _curseurOriginalControl;
        }

        private void EcranAPropos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
