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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            RolIdNumericUpDown1.Value = 0;
            idNumericUpDown1.Value = 0;
            textNombre.Text = string.Empty;
            txt_alias.Text = string.Empty;
            txt_usuario.Text = string.Empty;
            cb_rol.Text = string.Empty;
            dateTimePicker1.CustomFormat = " ";
            txt_email.Text = string.Empty;
            txt_clave.Text = string.Empty;
            txt_CC.Text = string.Empty;
            txt_CH.Text = string.Empty;

        }

        private void LlenaCampo(Usuario usuario)
        {
            RolIdNumericUpDown1.Value = usuario.IdR;
            idNumericUpDown1.Value = usuario.UsuarioId;
            textNombre.Text = usuario.Nombres;
            txt_alias.Text = usuario.Alias;
            txt_usuario.Text = usuario.UsuarioNombre;
            cb_rol.Text = usuario.RolId;
            dateTimePicker1.Value = usuario.FechaIngreso;
            txt_email.Text = usuario.Email;
            txt_clave.Text = usuario.Clave;
            checkBox1.Checked = usuario.Activo;
        }

        private Usuario LlenaClase()
        {
            Usuario usuario = new Usuario();
            usuario.UsuarioId = (int)idNumericUpDown1.Value;
            usuario.Nombres = textNombre.Text;
            usuario.Alias = txt_alias.Text;
            usuario.Clave = txt_clave.Text;
            usuario.FechaIngreso = dateTimePicker1.Value;
            usuario.RolId = cb_rol.Text;
            usuario.UsuarioNombre = txt_usuario.Text;
            usuario.Email = txt_email.Text;
            usuario.IdR = (int)RolIdNumericUpDown1.Value;
            usuario.Activo = checkBox1.Checked;
            return usuario;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Usuario usuarios;
            bool paso = false;

            if (!Validar())
                return;

            usuarios = LlenaClase();

            paso = UsuarioBll.Guardar(usuarios);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar, Id en existencia", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_validar_Click(object sender, EventArgs e)
        {

        }

        private void btn_validar_Click_1(object sender, EventArgs e)
        {
            bool pasos = true;
            errorProvider1.Clear();

            if (textNombre.Text == string.Empty)
            {
                errorProvider1.SetError(textNombre, "El campo nombre no puede estar vacio");
                textNombre.Focus();
                pasos = false;
            }

            if (string.IsNullOrWhiteSpace(txt_alias.Text.Replace("-", "")))
            {
                errorProvider1.SetError(txt_alias, "El campo alias no puede estar vacio");
                txt_alias.Focus();
                pasos = false;
            }

            if (string.IsNullOrWhiteSpace(txt_clave.Text.Replace("-", "")))
            {
                errorProvider1.SetError(txt_clave, "El campo cedula no puede estar vacio");
                txt_clave.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(dateTimePicker1.Text.Replace("-", "")))
            {
                errorProvider1.SetError(dateTimePicker1, "El campo Telefono no puede estar vacio");
                dateTimePicker1.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(cb_rol.Text.Replace("-", "")))
            {
                errorProvider1.SetError(cb_rol, "Debe agregar un rol especifico");
                cb_rol.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_usuario.Text.Replace("-", "")))
            {
                errorProvider1.SetError(txt_usuario, "El campo Telefono no puede estar vacio");
                txt_usuario.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_email.Text.Replace("-", "")))
            {
                errorProvider1.SetError(txt_email, "Debe agregar un rol especifico");
                txt_email.Focus();
                pasos = false;
            }
        }













        private bool ExisteEnLaBaseDeDatos()
        {
            Usuario usuario = UsuarioBll.Buscar((int)idNumericUpDown1.Value);

            return (usuario != null);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
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

            if (textNombre.Text == string.Empty)
            {
                errorProvider1.SetError(textNombre, "El campo nombre no puede estar vacio");
                textNombre.Focus();
                pasos = false;
            }

            if (string.IsNullOrWhiteSpace(txt_alias.Text.Replace("-", "")))
            {
                errorProvider1.SetError(txt_alias, "El campo alias no puede estar vacio");
                txt_alias.Focus();
                pasos = false;
            }

            if (string.IsNullOrWhiteSpace(txt_clave.Text.Replace("-", "")))
            {
                errorProvider1.SetError(txt_clave, "El campo cedula no puede estar vacio");
                txt_clave.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(dateTimePicker1.Text.Replace("-", "")))
            {
                errorProvider1.SetError(dateTimePicker1, "El campo Telefono no puede estar vacio");
                dateTimePicker1.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(cb_rol.Text.Replace("-", "")))
            {
                errorProvider1.SetError(cb_rol, "Debe agregar un rol especifico");
                cb_rol.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_usuario.Text.Replace("-", "")))
            {
                errorProvider1.SetError(txt_usuario, "El campo Telefono no puede estar vacio");
                txt_usuario.Focus();
                pasos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_email.Text.Replace("-", "")))
            {
                errorProvider1.SetError(txt_email, "Debe agregar un rol especifico");
                txt_email.Focus();
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
            cb_rol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}