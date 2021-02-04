using Proyecto_UsuarioF.Entidades;
using Proyecto_UsuarioF.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_UsuarioF.BLL;

namespace Proyecto_UsuarioF
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            idNumericUpDown1.Value = 0;
            texboxNombre.Clear();
            texboxAlias.Clear();
            texboxUsuario.Clear();
            comboboxRoles.Text = string.Empty;
            dateTimePicker1.CustomFormat = " ";
            texboxEmail.Clear();
            ClaveTexbox.Clear();
            ConfirmarClaveTexbox.Clear();
            CostoXHoraTexbox.Clear();

        }

        private void LlenaCampo(Usuario usuario)
        {
            idNumericUpDown1.Value = usuario.UsuarioId;
            texboxNombre.Text = usuario.Nombres;
            texboxAlias.Text = usuario.Alias;
            texboxUsuario.Text = usuario.UsuarioNombre;
            dateTimePicker1.Value = usuario.FechaIngreso;
            texboxEmail.Text = usuario.Email;
            ClaveTexbox.Text = usuario.Clave;
            checkBox1.Checked = usuario.Activo;
        }

        private Usuario LlenaClase()
        {
            Usuario usuario = new Usuario();
            usuario.UsuarioId = (int)idNumericUpDown1.Value;
            usuario.Nombres = texboxNombre.Text;
            usuario.Alias = texboxAlias.Text;
            usuario.Clave = ClaveTexbox.Text;
            usuario.FechaIngreso = dateTimePicker1.Value;
            usuario.UsuarioNombre = texboxUsuario.Text;
            usuario.Email = texboxEmail.Text;
            usuario.Activo = checkBox1.Checked;
            return usuario;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuario usuarios;
            bool paso = false;

            if (!Validar())
                return;

            usuarios = LlenaClase();

            paso = UsuarioBll.Guardar(usuarios);

            if (paso)
            {
                MessageBox.Show("Guardado!!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar, Id en existencia", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuario usuario = UsuarioBll.Buscar((int)idNumericUpDown1.Value);

            return (usuario != null);
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            int id;
            int.TryParse(idNumericUpDown1.Text, out id);

            Limpiar();

            if (UsuarioBll.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider1.SetError(idNumericUpDown1, "No se puede eliminar un usuario que no existe");
        }

        private bool Validar()
        {
            bool pasos = true;
            errorProvider1.Clear();

            if (texboxNombre.Text == string.Empty)
            {
                errorProvider1.SetError(texboxNombre, "El campo nombre no puede estar vacio");
                texboxNombre.Focus();
                pasos = false;
            }

            if (string.IsNullOrWhiteSpace(texboxAlias.Text.Replace("-", "")))
            {
                errorProvider1.SetError(texboxAlias, "El campo alias no puede estar vacio");
                texboxAlias.Focus();
                pasos = false;
            }

            if (string.IsNullOrWhiteSpace(ClaveTexbox.Text.Replace("-", "")))
            {
                errorProvider1.SetError(ClaveTexbox, "El campo cedula no puede estar vacio");
                ClaveTexbox.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(dateTimePicker1.Text.Replace("-", "")))
            {
                errorProvider1.SetError(dateTimePicker1, "El campo Telefono no puede estar vacio");
                dateTimePicker1.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(comboboxRoles.Text.Replace("-", "")))
            {
                errorProvider1.SetError(comboboxRoles, "Debe agregar un rol especifico");
                comboboxRoles.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(texboxUsuario.Text.Replace("-", "")))
            {
                errorProvider1.SetError(texboxUsuario, "El campo Telefono no puede estar vacio");
                texboxUsuario.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(texboxEmail.Text.Replace("-", "")))
            {
                errorProvider1.SetError(texboxEmail, "Debe agregar un rol especifico");
                texboxEmail.Focus();
                pasos = false;
            }
            return pasos;
        }
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void cb_rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BottonBuscar_Click(object sender, EventArgs e)
        {
            int id;
            Usuario usuario = new Usuario();
            int.TryParse(idNumericUpDown1.Text, out id);

            Limpiar();

            usuario = BLL.UsuarioBll.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("Usuario En Base de datos");
                LlenaCampo(usuario);
            }
            else
            {
                MessageBox.Show("Usuario no Existe");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_alias_TextChanged(object sender, EventArgs e)
        {

        }

        private void idNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void ClaveTexbox_TextChanged(object sender, EventArgs e)
        {
            if (ClaveTexbox != ConfirmarClaveTexbox)
            {
                errorProvider1.SetError(ClaveTexbox, "Las contrseñas no coinciden, Repetir");
                errorProvider1.SetError(ConfirmarClaveTexbox, "Las contrseñas no coinciden, Repetir");
            }
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}