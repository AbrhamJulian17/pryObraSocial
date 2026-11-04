namespace pryObraSocial
{
    public partial class frmAfiliado : Form
    {
        //(datos) valores de cada plan.
        int[] costos = { 20000, 25000, 40000, 50000, 65000 };

        //vectores donde se guardan los afiliados, solo cien.
        int[] vecNro = new int[10];
        string[] vecApellido = new string[10];
        string[] vecNombre = new string[10];
        string[] vecDni = new string[10];
        string[] vecTelefono = new string[10];
        string[] vecPlan = new string[10];
        int[] vecCosto = new int[10];
        int cantidad = 0;

        // El (Upper) sirve para poner en mayusculas.
        // (dropdownstyle) es para que se pueda elegir una opción, no escribir.
        // (27)Conecta el evento del combo con el método que lo atiende.
        public frmAfiliado()
        {
            InitializeComponent();
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.SelectedIndexChanged += cmbPlan_SelectedIndexChanged;
        }


        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedIndex != -1)
            {
                txtCosto.Text = costos[cmbPlan.SelectedIndex].ToString();
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int nro, dni;
            long tel;

            if (!int.TryParse(txtNroAfiliado.Text, out nro) || nro <= 0)
            {
                MessageBox.Show("N° de afiliado inválido");
                txtNroAfiliado.Focus();
                return;
            }
            for (int i = 0; i < cantidad; i++)
            {
                if (vecNro[i] == nro)
                {
                    MessageBox.Show("Ese N° de afiliado ya existe");
                    txtNroAfiliado.Focus();
                    return;
                }
            }
            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Ingresá el apellido");
                txtApellido.Focus();
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingresá el nombre");
                txtNombre.Focus();
                return;
            }
            if (!int.TryParse(txtDni.Text, out dni) || txtDni.Text.Length < 7 || txtDni.Text.Length > 8)
            {
                MessageBox.Show("El DNI debe tener 7 u 8 números");
                txtDni.Focus();
                return;
            }
            if (dtpFechaNacimiento.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Fecha de nacimiento inválida");
                return;
            }
            if (!long.TryParse(txtTelefono.Text, out tel) || txtTelefono.Text.Length < 8)
            {
                MessageBox.Show("Teléfono inválido");
                txtTelefono.Focus();
                return;
            }
            if (cmbPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná un plan");
                return;
            }

            // Guardar en archivo
            // Registrar
            vecNro[cantidad] = nro;
            vecApellido[cantidad] = txtApellido.Text;
            vecNombre[cantidad] = txtNombre.Text;
            vecDni[cantidad] = txtDni.Text;
            vecTelefono[cantidad] = txtTelefono.Text;
            vecPlan[cantidad] = cmbPlan.Text;
            vecCosto[cantidad] = costos[cmbPlan.SelectedIndex];

            // Guardar en archivo
            StreamWriter sw = new StreamWriter("afiliados.txt", true);
            sw.WriteLine(nro + ";" + txtApellido.Text + ";" + txtNombre.Text + ";" + dni + ";" +
                         dtpFechaNacimiento.Value.ToShortDateString() + ";" + tel + ";" +
                         cmbPlan.Text + ";" + txtCosto.Text);
            sw.Close();

            cantidad++;

            MessageBox.Show("Afiliado registrado. Total: " + cantidad);

            // Limpiar el formulario
            txtNroAfiliado.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            cmbPlan.SelectedIndex = -1;
            txtCosto.Clear();
            txtNroAfiliado.Focus();
        }
        private void solonumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}