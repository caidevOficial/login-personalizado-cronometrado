﻿/*
 ------------------------------------------------------------------------
 |  LOGIN / INICIO DE SESION 3 INTENTOS, CONTROLADO POR TEMPORIZADOR    |
 |-----------------------------------------------------------------------
 | Pequeña descripción: Login desarrollado que permite solamente tres   |
 | intentos, si el usuario sobrepasa el número de intentos permitidos   |
 | la aplicación se bloquea por 50 segundos, y transcurrido ese tiempo  |
 | podrá intentar ingresar nuevamente. Se añadieron mensajes nuevos     |
 | mensajes personalizados de notificaciones, en el cual usted es libre |
 | de modificarlos según sus necesidades.                               |
 |-----------------------------------------------------------------------
 | Proyecto compartido con fines académicos.                            |
 | © Copyright 2020 Daniel Rivera.                                      |                                        
 | https://github.com/DanielRivera03                                    |
 | Créditos icono robot: https://www.pngwing.com/es/free-png-nvjtw      |
 |-----------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_Calzado
{
    public partial class MensajeErrorDB : Form
    {
        public MensajeErrorDB()
        {
            InitializeComponent();
            Opacity = .95;
        }

        // CIERRE VENTANA CONTENEDOR MENSAJE
        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // CIERRE VENTANA CONTENEDOR SUPERIOR
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // POSICION VENTANA EMERGENTE PANTALLA PERSONALIZADO
        private void MensajeErrorDB_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height);
        }
    }
}
