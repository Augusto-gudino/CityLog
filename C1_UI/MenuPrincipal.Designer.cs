﻿namespace C1_UI
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_barra_titulo = new System.Windows.Forms.Panel();
            this.pictureboxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxExpandir = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.menu_vertical_principal = new System.Windows.Forms.Panel();
            this.btnConoceNuestrosProveedores = new System.Windows.Forms.Button();
            this.panelBtnMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnSnacks = new System.Windows.Forms.Button();
            this.btnGolosinas = new System.Windows.Forms.Button();
            this.btnCervezas = new System.Windows.Forms.Button();
            this.btnBebidasSinAlcohol = new System.Windows.Forms.Button();
            this.pictureBoxInicio = new System.Windows.Forms.PictureBox();
            this.panelContenedorPrincipal = new System.Windows.Forms.Panel();
            this.panelSubmenuSnacks = new System.Windows.Forms.Panel();
            this.btnEliminarPedidoSnacks = new System.Windows.Forms.Button();
            this.btnMostrarPedidoSnacks = new System.Windows.Forms.Button();
            this.btnBuscarPedidoSnacks = new System.Windows.Forms.Button();
            this.btnCrearPedidoSnacks = new System.Windows.Forms.Button();
            this.panelSubmenuCervezas = new System.Windows.Forms.Panel();
            this.btnEliminarPedidoCerveza = new System.Windows.Forms.Button();
            this.panelSubmenuGolosinas = new System.Windows.Forms.Panel();
            this.btnEliminarPedidoGolosinas = new System.Windows.Forms.Button();
            this.btnMostrarPedidoGolosinas = new System.Windows.Forms.Button();
            this.btnBuscarPedidoGolosinas = new System.Windows.Forms.Button();
            this.btnCrearPedidoGolosinas = new System.Windows.Forms.Button();
            this.btnMostrarPedidoCerveza = new System.Windows.Forms.Button();
            this.btnBuscarPedidoCerveza = new System.Windows.Forms.Button();
            this.btnCrearPedidoCerveza = new System.Windows.Forms.Button();
            this.panelSubmenuBebidasSinAlcohol = new System.Windows.Forms.Panel();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.btnMostrarBebidasSinAlcohol = new System.Windows.Forms.Button();
            this.btnBuscarBebidaSinAlcohol = new System.Windows.Forms.Button();
            this.btnCrearPedidoBebidaSinAlcohol = new System.Windows.Forms.Button();
            this.panel_barra_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            this.menu_vertical_principal.SuspendLayout();
            this.panelBtnMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicio)).BeginInit();
            this.panelContenedorPrincipal.SuspendLayout();
            this.panelSubmenuSnacks.SuspendLayout();
            this.panelSubmenuCervezas.SuspendLayout();
            this.panelSubmenuGolosinas.SuspendLayout();
            this.panelSubmenuBebidasSinAlcohol.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_barra_titulo
            // 
            this.panel_barra_titulo.BackColor = System.Drawing.Color.DarkOrange;
            this.panel_barra_titulo.Controls.Add(this.pictureboxMinimizar);
            this.panel_barra_titulo.Controls.Add(this.pictureBoxExpandir);
            this.panel_barra_titulo.Controls.Add(this.pictureBoxCerrar);
            this.panel_barra_titulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_barra_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra_titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_barra_titulo.Name = "panel_barra_titulo";
            this.panel_barra_titulo.Size = new System.Drawing.Size(1300, 38);
            this.panel_barra_titulo.TabIndex = 0;
            // 
            // pictureboxMinimizar
            // 
            this.pictureboxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxMinimizar.Image = global::C1_UI.Properties.Resources.minimizar;
            this.pictureboxMinimizar.Location = new System.Drawing.Point(1213, 3);
            this.pictureboxMinimizar.Name = "pictureboxMinimizar";
            this.pictureboxMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pictureboxMinimizar.TabIndex = 0;
            this.pictureboxMinimizar.TabStop = false;
            this.pictureboxMinimizar.Click += new System.EventHandler(this.pictureboxMinimizar_Click);
            // 
            // pictureBoxExpandir
            // 
            this.pictureBoxExpandir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExpandir.Image = global::C1_UI.Properties.Resources.tamano_completo;
            this.pictureBoxExpandir.Location = new System.Drawing.Point(1244, 3);
            this.pictureBoxExpandir.Name = "pictureBoxExpandir";
            this.pictureBoxExpandir.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxExpandir.TabIndex = 1;
            this.pictureBoxExpandir.TabStop = false;
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = global::C1_UI.Properties.Resources.cerrar_simbolo_de_boton_circular;
            this.pictureBoxCerrar.Location = new System.Drawing.Point(1275, 3);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxCerrar.TabIndex = 2;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // menu_vertical_principal
            // 
            this.menu_vertical_principal.BackColor = System.Drawing.Color.BurlyWood;
            this.menu_vertical_principal.Controls.Add(this.btnConoceNuestrosProveedores);
            this.menu_vertical_principal.Controls.Add(this.panelBtnMenuPrincipal);
            this.menu_vertical_principal.Controls.Add(this.pictureBoxInicio);
            this.menu_vertical_principal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_vertical_principal.Location = new System.Drawing.Point(0, 38);
            this.menu_vertical_principal.Name = "menu_vertical_principal";
            this.menu_vertical_principal.Size = new System.Drawing.Size(220, 612);
            this.menu_vertical_principal.TabIndex = 0;
            // 
            // btnConoceNuestrosProveedores
            // 
            this.btnConoceNuestrosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConoceNuestrosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConoceNuestrosProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConoceNuestrosProveedores.Image = global::C1_UI.Properties.Resources.favorecido;
            this.btnConoceNuestrosProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConoceNuestrosProveedores.Location = new System.Drawing.Point(0, 541);
            this.btnConoceNuestrosProveedores.Name = "btnConoceNuestrosProveedores";
            this.btnConoceNuestrosProveedores.Size = new System.Drawing.Size(217, 59);
            this.btnConoceNuestrosProveedores.TabIndex = 0;
            this.btnConoceNuestrosProveedores.Text = "Conoce nuestros \r\nproveedores";
            this.btnConoceNuestrosProveedores.UseVisualStyleBackColor = true;
            this.btnConoceNuestrosProveedores.Click += new System.EventHandler(this.btnConoceNuestrosProveedores_Click);
            // 
            // panelBtnMenuPrincipal
            // 
            this.panelBtnMenuPrincipal.Controls.Add(this.btnSnacks);
            this.panelBtnMenuPrincipal.Controls.Add(this.btnGolosinas);
            this.panelBtnMenuPrincipal.Controls.Add(this.btnCervezas);
            this.panelBtnMenuPrincipal.Controls.Add(this.btnBebidasSinAlcohol);
            this.panelBtnMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBtnMenuPrincipal.Location = new System.Drawing.Point(6, 170);
            this.panelBtnMenuPrincipal.Name = "panelBtnMenuPrincipal";
            this.panelBtnMenuPrincipal.Size = new System.Drawing.Size(211, 365);
            this.panelBtnMenuPrincipal.TabIndex = 2;
            // 
            // btnSnacks
            // 
            this.btnSnacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnacks.Image = global::C1_UI.Properties.Resources.bebidas_sin_alcohol;
            this.btnSnacks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSnacks.Location = new System.Drawing.Point(0, 271);
            this.btnSnacks.Name = "btnSnacks";
            this.btnSnacks.Size = new System.Drawing.Size(208, 59);
            this.btnSnacks.TabIndex = 2;
            this.btnSnacks.Text = "Snacks";
            this.btnSnacks.UseVisualStyleBackColor = true;
            this.btnSnacks.Click += new System.EventHandler(this.btnSnacks_Click);
            // 
            // btnGolosinas
            // 
            this.btnGolosinas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGolosinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGolosinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGolosinas.Image = global::C1_UI.Properties.Resources.golosinas;
            this.btnGolosinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGolosinas.Location = new System.Drawing.Point(0, 195);
            this.btnGolosinas.Name = "btnGolosinas";
            this.btnGolosinas.Size = new System.Drawing.Size(208, 59);
            this.btnGolosinas.TabIndex = 2;
            this.btnGolosinas.Text = "Golosinas\r\n";
            this.btnGolosinas.UseVisualStyleBackColor = true;
            this.btnGolosinas.Click += new System.EventHandler(this.btnGolosinas_Click);
            // 
            // btnCervezas
            // 
            this.btnCervezas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCervezas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCervezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCervezas.Image = global::C1_UI.Properties.Resources.salud;
            this.btnCervezas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCervezas.Location = new System.Drawing.Point(0, 117);
            this.btnCervezas.Name = "btnCervezas";
            this.btnCervezas.Size = new System.Drawing.Size(208, 59);
            this.btnCervezas.TabIndex = 2;
            this.btnCervezas.Text = "Cervezas\r\n";
            this.btnCervezas.UseVisualStyleBackColor = true;
            this.btnCervezas.Click += new System.EventHandler(this.btnCervezas_Click);
            // 
            // btnBebidasSinAlcohol
            // 
            this.btnBebidasSinAlcohol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBebidasSinAlcohol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBebidasSinAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebidasSinAlcohol.Image = global::C1_UI.Properties.Resources.bebidas_sin_alcohol;
            this.btnBebidasSinAlcohol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBebidasSinAlcohol.Location = new System.Drawing.Point(0, 39);
            this.btnBebidasSinAlcohol.Name = "btnBebidasSinAlcohol";
            this.btnBebidasSinAlcohol.Size = new System.Drawing.Size(208, 59);
            this.btnBebidasSinAlcohol.TabIndex = 1;
            this.btnBebidasSinAlcohol.Text = "Bebidas sin\r\nalcohol\r\n";
            this.btnBebidasSinAlcohol.UseVisualStyleBackColor = true;
            this.btnBebidasSinAlcohol.Click += new System.EventHandler(this.btnBebidasSinAlcohol_Click);
            // 
            // pictureBoxInicio
            // 
            this.pictureBoxInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInicio.Image = global::C1_UI.Properties.Resources.LogoCityLog_Photoroom;
            this.pictureBoxInicio.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxInicio.Name = "pictureBoxInicio";
            this.pictureBoxInicio.Size = new System.Drawing.Size(214, 164);
            this.pictureBoxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInicio.TabIndex = 2;
            this.pictureBoxInicio.TabStop = false;
            // 
            // panelContenedorPrincipal
            // 
            this.panelContenedorPrincipal.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelContenedorPrincipal.Controls.Add(this.panelSubmenuSnacks);
            this.panelContenedorPrincipal.Controls.Add(this.panelSubmenuGolosinas);
            this.panelContenedorPrincipal.Controls.Add(this.panelSubmenuCervezas);
            this.panelContenedorPrincipal.Controls.Add(this.panelSubmenuBebidasSinAlcohol);
            this.panelContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorPrincipal.Location = new System.Drawing.Point(220, 38);
            this.panelContenedorPrincipal.Name = "panelContenedorPrincipal";
            this.panelContenedorPrincipal.Size = new System.Drawing.Size(1080, 612);
            this.panelContenedorPrincipal.TabIndex = 1;
            // 
            // panelSubmenuSnacks
            // 
            this.panelSubmenuSnacks.Controls.Add(this.btnEliminarPedidoSnacks);
            this.panelSubmenuSnacks.Controls.Add(this.btnMostrarPedidoSnacks);
            this.panelSubmenuSnacks.Controls.Add(this.btnBuscarPedidoSnacks);
            this.panelSubmenuSnacks.Controls.Add(this.btnCrearPedidoSnacks);
            this.panelSubmenuSnacks.Location = new System.Drawing.Point(3, 442);
            this.panelSubmenuSnacks.Name = "panelSubmenuSnacks";
            this.panelSubmenuSnacks.Size = new System.Drawing.Size(361, 72);
            this.panelSubmenuSnacks.TabIndex = 5;
            this.panelSubmenuSnacks.Visible = false;
            // 
            // btnEliminarPedidoSnacks
            // 
            this.btnEliminarPedidoSnacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPedidoSnacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPedidoSnacks.Image = global::C1_UI.Properties.Resources.eliminar;
            this.btnEliminarPedidoSnacks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPedidoSnacks.Location = new System.Drawing.Point(182, 39);
            this.btnEliminarPedidoSnacks.Name = "btnEliminarPedidoSnacks";
            this.btnEliminarPedidoSnacks.Size = new System.Drawing.Size(176, 32);
            this.btnEliminarPedidoSnacks.TabIndex = 3;
            this.btnEliminarPedidoSnacks.Text = "Eliminar pedido";
            this.btnEliminarPedidoSnacks.UseVisualStyleBackColor = true;
            // 
            // btnMostrarPedidoSnacks
            // 
            this.btnMostrarPedidoSnacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarPedidoSnacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPedidoSnacks.Image = global::C1_UI.Properties.Resources.lista;
            this.btnMostrarPedidoSnacks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarPedidoSnacks.Location = new System.Drawing.Point(182, 0);
            this.btnMostrarPedidoSnacks.Name = "btnMostrarPedidoSnacks";
            this.btnMostrarPedidoSnacks.Size = new System.Drawing.Size(176, 32);
            this.btnMostrarPedidoSnacks.TabIndex = 3;
            this.btnMostrarPedidoSnacks.Text = "Mostrar pedido";
            this.btnMostrarPedidoSnacks.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPedidoSnacks
            // 
            this.btnBuscarPedidoSnacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPedidoSnacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedidoSnacks.Image = global::C1_UI.Properties.Resources.buscar1;
            this.btnBuscarPedidoSnacks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPedidoSnacks.Location = new System.Drawing.Point(0, 38);
            this.btnBuscarPedidoSnacks.Name = "btnBuscarPedidoSnacks";
            this.btnBuscarPedidoSnacks.Size = new System.Drawing.Size(176, 32);
            this.btnBuscarPedidoSnacks.TabIndex = 4;
            this.btnBuscarPedidoSnacks.Text = "Buscar pedido";
            this.btnBuscarPedidoSnacks.UseVisualStyleBackColor = true;
            // 
            // btnCrearPedidoSnacks
            // 
            this.btnCrearPedidoSnacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPedidoSnacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPedidoSnacks.Image = global::C1_UI.Properties.Resources.agregar;
            this.btnCrearPedidoSnacks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPedidoSnacks.Location = new System.Drawing.Point(0, 0);
            this.btnCrearPedidoSnacks.Name = "btnCrearPedidoSnacks";
            this.btnCrearPedidoSnacks.Size = new System.Drawing.Size(176, 32);
            this.btnCrearPedidoSnacks.TabIndex = 0;
            this.btnCrearPedidoSnacks.Text = "Crear pedido";
            this.btnCrearPedidoSnacks.UseVisualStyleBackColor = true;
            // 
            // panelSubmenuCervezas
            // 
            this.panelSubmenuCervezas.Controls.Add(this.btnEliminarPedidoCerveza);
            this.panelSubmenuCervezas.Controls.Add(this.btnMostrarPedidoCerveza);
            this.panelSubmenuCervezas.Controls.Add(this.btnBuscarPedidoCerveza);
            this.panelSubmenuCervezas.Controls.Add(this.btnCrearPedidoCerveza);
            this.panelSubmenuCervezas.Location = new System.Drawing.Point(3, 287);
            this.panelSubmenuCervezas.Name = "panelSubmenuCervezas";
            this.panelSubmenuCervezas.Size = new System.Drawing.Size(359, 73);
            this.panelSubmenuCervezas.TabIndex = 3;
            this.panelSubmenuCervezas.Visible = false;
            // 
            // btnEliminarPedidoCerveza
            // 
            this.btnEliminarPedidoCerveza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPedidoCerveza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPedidoCerveza.Image = global::C1_UI.Properties.Resources.eliminar;
            this.btnEliminarPedidoCerveza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPedidoCerveza.Location = new System.Drawing.Point(182, 38);
            this.btnEliminarPedidoCerveza.Name = "btnEliminarPedidoCerveza";
            this.btnEliminarPedidoCerveza.Size = new System.Drawing.Size(176, 32);
            this.btnEliminarPedidoCerveza.TabIndex = 3;
            this.btnEliminarPedidoCerveza.Text = "Eliminar pedido";
            this.btnEliminarPedidoCerveza.UseVisualStyleBackColor = true;
            // 
            // panelSubmenuGolosinas
            // 
            this.panelSubmenuGolosinas.Controls.Add(this.btnEliminarPedidoGolosinas);
            this.panelSubmenuGolosinas.Controls.Add(this.btnMostrarPedidoGolosinas);
            this.panelSubmenuGolosinas.Controls.Add(this.btnBuscarPedidoGolosinas);
            this.panelSubmenuGolosinas.Controls.Add(this.btnCrearPedidoGolosinas);
            this.panelSubmenuGolosinas.Location = new System.Drawing.Point(3, 366);
            this.panelSubmenuGolosinas.Name = "panelSubmenuGolosinas";
            this.panelSubmenuGolosinas.Size = new System.Drawing.Size(361, 74);
            this.panelSubmenuGolosinas.TabIndex = 4;
            this.panelSubmenuGolosinas.Visible = false;
            // 
            // btnEliminarPedidoGolosinas
            // 
            this.btnEliminarPedidoGolosinas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPedidoGolosinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPedidoGolosinas.Image = global::C1_UI.Properties.Resources.eliminar;
            this.btnEliminarPedidoGolosinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPedidoGolosinas.Location = new System.Drawing.Point(182, 38);
            this.btnEliminarPedidoGolosinas.Name = "btnEliminarPedidoGolosinas";
            this.btnEliminarPedidoGolosinas.Size = new System.Drawing.Size(176, 32);
            this.btnEliminarPedidoGolosinas.TabIndex = 3;
            this.btnEliminarPedidoGolosinas.Text = "Eliminar pedido";
            this.btnEliminarPedidoGolosinas.UseVisualStyleBackColor = true;
            // 
            // btnMostrarPedidoGolosinas
            // 
            this.btnMostrarPedidoGolosinas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarPedidoGolosinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPedidoGolosinas.Image = global::C1_UI.Properties.Resources.lista;
            this.btnMostrarPedidoGolosinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarPedidoGolosinas.Location = new System.Drawing.Point(182, 0);
            this.btnMostrarPedidoGolosinas.Name = "btnMostrarPedidoGolosinas";
            this.btnMostrarPedidoGolosinas.Size = new System.Drawing.Size(176, 32);
            this.btnMostrarPedidoGolosinas.TabIndex = 3;
            this.btnMostrarPedidoGolosinas.Text = "Mostrar pedido";
            this.btnMostrarPedidoGolosinas.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPedidoGolosinas
            // 
            this.btnBuscarPedidoGolosinas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPedidoGolosinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedidoGolosinas.Image = global::C1_UI.Properties.Resources.buscar1;
            this.btnBuscarPedidoGolosinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPedidoGolosinas.Location = new System.Drawing.Point(0, 38);
            this.btnBuscarPedidoGolosinas.Name = "btnBuscarPedidoGolosinas";
            this.btnBuscarPedidoGolosinas.Size = new System.Drawing.Size(176, 32);
            this.btnBuscarPedidoGolosinas.TabIndex = 4;
            this.btnBuscarPedidoGolosinas.Text = "Buscar pedido";
            this.btnBuscarPedidoGolosinas.UseVisualStyleBackColor = true;
            // 
            // btnCrearPedidoGolosinas
            // 
            this.btnCrearPedidoGolosinas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPedidoGolosinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPedidoGolosinas.Image = global::C1_UI.Properties.Resources.agregar;
            this.btnCrearPedidoGolosinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPedidoGolosinas.Location = new System.Drawing.Point(0, 0);
            this.btnCrearPedidoGolosinas.Name = "btnCrearPedidoGolosinas";
            this.btnCrearPedidoGolosinas.Size = new System.Drawing.Size(176, 32);
            this.btnCrearPedidoGolosinas.TabIndex = 0;
            this.btnCrearPedidoGolosinas.Text = "Crear pedido";
            this.btnCrearPedidoGolosinas.UseVisualStyleBackColor = true;
            // 
            // btnMostrarPedidoCerveza
            // 
            this.btnMostrarPedidoCerveza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarPedidoCerveza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPedidoCerveza.Image = global::C1_UI.Properties.Resources.lista;
            this.btnMostrarPedidoCerveza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarPedidoCerveza.Location = new System.Drawing.Point(182, 0);
            this.btnMostrarPedidoCerveza.Name = "btnMostrarPedidoCerveza";
            this.btnMostrarPedidoCerveza.Size = new System.Drawing.Size(176, 32);
            this.btnMostrarPedidoCerveza.TabIndex = 3;
            this.btnMostrarPedidoCerveza.Text = "Mostrar pedido";
            this.btnMostrarPedidoCerveza.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPedidoCerveza
            // 
            this.btnBuscarPedidoCerveza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPedidoCerveza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedidoCerveza.Image = global::C1_UI.Properties.Resources.buscar1;
            this.btnBuscarPedidoCerveza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPedidoCerveza.Location = new System.Drawing.Point(0, 38);
            this.btnBuscarPedidoCerveza.Name = "btnBuscarPedidoCerveza";
            this.btnBuscarPedidoCerveza.Size = new System.Drawing.Size(176, 32);
            this.btnBuscarPedidoCerveza.TabIndex = 4;
            this.btnBuscarPedidoCerveza.Text = "Buscar pedido";
            this.btnBuscarPedidoCerveza.UseVisualStyleBackColor = true;
            // 
            // btnCrearPedidoCerveza
            // 
            this.btnCrearPedidoCerveza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPedidoCerveza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPedidoCerveza.Image = global::C1_UI.Properties.Resources.agregar;
            this.btnCrearPedidoCerveza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPedidoCerveza.Location = new System.Drawing.Point(0, 0);
            this.btnCrearPedidoCerveza.Name = "btnCrearPedidoCerveza";
            this.btnCrearPedidoCerveza.Size = new System.Drawing.Size(176, 32);
            this.btnCrearPedidoCerveza.TabIndex = 0;
            this.btnCrearPedidoCerveza.Text = "Crear pedido";
            this.btnCrearPedidoCerveza.UseVisualStyleBackColor = true;
            // 
            // panelSubmenuBebidasSinAlcohol
            // 
            this.panelSubmenuBebidasSinAlcohol.Controls.Add(this.btnEliminarPedido);
            this.panelSubmenuBebidasSinAlcohol.Controls.Add(this.btnMostrarBebidasSinAlcohol);
            this.panelSubmenuBebidasSinAlcohol.Controls.Add(this.btnBuscarBebidaSinAlcohol);
            this.panelSubmenuBebidasSinAlcohol.Controls.Add(this.btnCrearPedidoBebidaSinAlcohol);
            this.panelSubmenuBebidasSinAlcohol.Location = new System.Drawing.Point(3, 209);
            this.panelSubmenuBebidasSinAlcohol.Name = "panelSubmenuBebidasSinAlcohol";
            this.panelSubmenuBebidasSinAlcohol.Size = new System.Drawing.Size(361, 72);
            this.panelSubmenuBebidasSinAlcohol.TabIndex = 2;
            this.panelSubmenuBebidasSinAlcohol.Visible = false;
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPedido.Image = global::C1_UI.Properties.Resources.eliminar;
            this.btnEliminarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPedido.Location = new System.Drawing.Point(182, 38);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(176, 32);
            this.btnEliminarPedido.TabIndex = 3;
            this.btnEliminarPedido.Text = "Eliminar pedido";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            // 
            // btnMostrarBebidasSinAlcohol
            // 
            this.btnMostrarBebidasSinAlcohol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarBebidasSinAlcohol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarBebidasSinAlcohol.Image = global::C1_UI.Properties.Resources.lista;
            this.btnMostrarBebidasSinAlcohol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarBebidasSinAlcohol.Location = new System.Drawing.Point(182, 3);
            this.btnMostrarBebidasSinAlcohol.Name = "btnMostrarBebidasSinAlcohol";
            this.btnMostrarBebidasSinAlcohol.Size = new System.Drawing.Size(176, 32);
            this.btnMostrarBebidasSinAlcohol.TabIndex = 3;
            this.btnMostrarBebidasSinAlcohol.Text = "Mostrar pedido";
            this.btnMostrarBebidasSinAlcohol.UseVisualStyleBackColor = true;
            // 
            // btnBuscarBebidaSinAlcohol
            // 
            this.btnBuscarBebidaSinAlcohol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarBebidaSinAlcohol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarBebidaSinAlcohol.Image = global::C1_UI.Properties.Resources.buscar1;
            this.btnBuscarBebidaSinAlcohol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarBebidaSinAlcohol.Location = new System.Drawing.Point(0, 38);
            this.btnBuscarBebidaSinAlcohol.Name = "btnBuscarBebidaSinAlcohol";
            this.btnBuscarBebidaSinAlcohol.Size = new System.Drawing.Size(176, 32);
            this.btnBuscarBebidaSinAlcohol.TabIndex = 4;
            this.btnBuscarBebidaSinAlcohol.Text = "Buscar pedido";
            this.btnBuscarBebidaSinAlcohol.UseVisualStyleBackColor = true;
            // 
            // btnCrearPedidoBebidaSinAlcohol
            // 
            this.btnCrearPedidoBebidaSinAlcohol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPedidoBebidaSinAlcohol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPedidoBebidaSinAlcohol.Image = global::C1_UI.Properties.Resources.agregar;
            this.btnCrearPedidoBebidaSinAlcohol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPedidoBebidaSinAlcohol.Location = new System.Drawing.Point(0, 0);
            this.btnCrearPedidoBebidaSinAlcohol.Name = "btnCrearPedidoBebidaSinAlcohol";
            this.btnCrearPedidoBebidaSinAlcohol.Size = new System.Drawing.Size(176, 32);
            this.btnCrearPedidoBebidaSinAlcohol.TabIndex = 0;
            this.btnCrearPedidoBebidaSinAlcohol.Text = "Crear pedido";
            this.btnCrearPedidoBebidaSinAlcohol.UseVisualStyleBackColor = true;
            this.btnCrearPedidoBebidaSinAlcohol.Click += new System.EventHandler(this.btnCrearPedidoBebidaSinAlcohol_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedorPrincipal);
            this.Controls.Add(this.menu_vertical_principal);
            this.Controls.Add(this.panel_barra_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.panel_barra_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            this.menu_vertical_principal.ResumeLayout(false);
            this.panelBtnMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicio)).EndInit();
            this.panelContenedorPrincipal.ResumeLayout(false);
            this.panelSubmenuSnacks.ResumeLayout(false);
            this.panelSubmenuCervezas.ResumeLayout(false);
            this.panelSubmenuGolosinas.ResumeLayout(false);
            this.panelSubmenuBebidasSinAlcohol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barra_titulo;
        private System.Windows.Forms.Panel menu_vertical_principal;
        private System.Windows.Forms.Panel panelContenedorPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxInicio;
        private System.Windows.Forms.PictureBox pictureboxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxExpandir;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.Button btnConoceNuestrosProveedores;
        private System.Windows.Forms.Panel panelBtnMenuPrincipal;
        private System.Windows.Forms.Button btnBebidasSinAlcohol;
        private System.Windows.Forms.Button btnSnacks;
        private System.Windows.Forms.Button btnGolosinas;
        private System.Windows.Forms.Button btnCervezas;
        private System.Windows.Forms.Panel panelSubmenuBebidasSinAlcohol;
        private System.Windows.Forms.Button btnCrearPedidoBebidaSinAlcohol;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnMostrarBebidasSinAlcohol;
        private System.Windows.Forms.Button btnBuscarBebidaSinAlcohol;
        private System.Windows.Forms.Panel panelSubmenuSnacks;
        private System.Windows.Forms.Button btnEliminarPedidoSnacks;
        private System.Windows.Forms.Button btnMostrarPedidoSnacks;
        private System.Windows.Forms.Button btnBuscarPedidoSnacks;
        private System.Windows.Forms.Button btnCrearPedidoSnacks;
        private System.Windows.Forms.Panel panelSubmenuGolosinas;
        private System.Windows.Forms.Button btnEliminarPedidoGolosinas;
        private System.Windows.Forms.Button btnMostrarPedidoGolosinas;
        private System.Windows.Forms.Button btnBuscarPedidoGolosinas;
        private System.Windows.Forms.Button btnCrearPedidoGolosinas;
        private System.Windows.Forms.Panel panelSubmenuCervezas;
        private System.Windows.Forms.Button btnEliminarPedidoCerveza;
        private System.Windows.Forms.Button btnMostrarPedidoCerveza;
        private System.Windows.Forms.Button btnBuscarPedidoCerveza;
        private System.Windows.Forms.Button btnCrearPedidoCerveza;
    }
}