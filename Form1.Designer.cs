
namespace Interfaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.res4 = new System.Windows.Forms.TextBox();
            this.res3 = new System.Windows.Forms.TextBox();
            this.res2 = new System.Windows.Forms.TextBox();
            this.res1 = new System.Windows.Forms.ComboBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelTalla = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.res16 = new System.Windows.Forms.ComboBox();
            this.res15 = new System.Windows.Forms.ComboBox();
            this.res14 = new System.Windows.Forms.TextBox();
            this.res13 = new System.Windows.Forms.TextBox();
            this.res12 = new System.Windows.Forms.ComboBox();
            this.res11 = new System.Windows.Forms.TextBox();
            this.res10 = new System.Windows.Forms.ComboBox();
            this.res9 = new System.Windows.Forms.ComboBox();
            this.res8 = new System.Windows.Forms.TextBox();
            this.res7 = new System.Windows.Forms.TextBox();
            this.res6 = new System.Windows.Forms.ComboBox();
            this.res5 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSobrePeso = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.respuesta = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRes
            // 
            this.buttonRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(221)))));
            this.buttonRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRes.Location = new System.Drawing.Point(23, 327);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(234, 81);
            this.buttonRes.TabIndex = 0;
            this.buttonRes.TabStop = false;
            this.buttonRes.Text = "Realizar diagnóstico";
            this.buttonRes.UseVisualStyleBackColor = false;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            this.buttonRes.MouseLeave += new System.EventHandler(this.buttonRes_MouseLeave);
            this.buttonRes.MouseHover += new System.EventHandler(this.buttonRes_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.res4);
            this.panel1.Controls.Add(this.res3);
            this.panel1.Controls.Add(this.res2);
            this.panel1.Controls.Add(this.res1);
            this.panel1.Controls.Add(this.labelPeso);
            this.panel1.Controls.Add(this.labelTalla);
            this.panel1.Controls.Add(this.labelEdad);
            this.panel1.Controls.Add(this.labelGenero);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 138);
            this.panel1.TabIndex = 1;
            // 
            // res4
            // 
            this.res4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res4.Location = new System.Drawing.Point(90, 102);
            this.res4.Name = "res4";
            this.res4.Size = new System.Drawing.Size(121, 15);
            this.res4.TabIndex = 5;
            // 
            // res3
            // 
            this.res3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res3.Location = new System.Drawing.Point(90, 74);
            this.res3.Name = "res3";
            this.res3.Size = new System.Drawing.Size(121, 15);
            this.res3.TabIndex = 4;
            // 
            // res2
            // 
            this.res2.AccessibleDescription = "res2";
            this.res2.AccessibleName = "res2";
            this.res2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res2.Location = new System.Drawing.Point(90, 46);
            this.res2.Name = "res2";
            this.res2.Size = new System.Drawing.Size(121, 15);
            this.res2.TabIndex = 0;
            // 
            // res1
            // 
            this.res1.BackColor = System.Drawing.Color.White;
            this.res1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.res1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.res1.FormattingEnabled = true;
            this.res1.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.res1.Location = new System.Drawing.Point(90, 11);
            this.res1.Name = "res1";
            this.res1.Size = new System.Drawing.Size(121, 24);
            this.res1.TabIndex = 0;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(3, 97);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(63, 24);
            this.labelPeso.TabIndex = 3;
            this.labelPeso.Text = "Peso: ";
            // 
            // labelTalla
            // 
            this.labelTalla.AutoSize = true;
            this.labelTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTalla.Location = new System.Drawing.Point(3, 69);
            this.labelTalla.Name = "labelTalla";
            this.labelTalla.Size = new System.Drawing.Size(60, 24);
            this.labelTalla.TabIndex = 2;
            this.labelTalla.Text = "Talla: ";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(3, 41);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(65, 24);
            this.labelEdad.TabIndex = 1;
            this.labelEdad.Text = "Edad: ";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(3, 11);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(84, 24);
            this.labelGenero.TabIndex = 0;
            this.labelGenero.Text = "Género: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.res16);
            this.panel2.Controls.Add(this.res15);
            this.panel2.Controls.Add(this.res14);
            this.panel2.Controls.Add(this.res13);
            this.panel2.Controls.Add(this.res12);
            this.panel2.Controls.Add(this.res11);
            this.panel2.Controls.Add(this.res10);
            this.panel2.Controls.Add(this.res9);
            this.panel2.Controls.Add(this.res8);
            this.panel2.Controls.Add(this.res7);
            this.panel2.Controls.Add(this.res6);
            this.panel2.Controls.Add(this.res5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelSobrePeso);
            this.panel2.Location = new System.Drawing.Point(289, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 730);
            this.panel2.TabIndex = 2;
            // 
            // res16
            // 
            this.res16.BackColor = System.Drawing.Color.White;
            this.res16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.res16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.res16.FormattingEnabled = true;
            this.res16.Items.AddRange(new object[] {
            "Transporte público",
            "Auto",
            "Caminando",
            "Motocicleta",
            "Bicicleta"});
            this.res16.Location = new System.Drawing.Point(281, 694);
            this.res16.Name = "res16";
            this.res16.Size = new System.Drawing.Size(121, 24);
            this.res16.TabIndex = 27;
            // 
            // res15
            // 
            this.res15.BackColor = System.Drawing.Color.White;
            this.res15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.res15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.res15.FormattingEnabled = true;
            this.res15.Items.AddRange(new object[] {
            "No",
            "Algunas veces",
            "Frecuentemente",
            "Siempre"});
            this.res15.Location = new System.Drawing.Point(281, 649);
            this.res15.Name = "res15";
            this.res15.Size = new System.Drawing.Size(121, 24);
            this.res15.TabIndex = 26;
            // 
            // res14
            // 
            this.res14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res14.Location = new System.Drawing.Point(281, 615);
            this.res14.Name = "res14";
            this.res14.Size = new System.Drawing.Size(121, 15);
            this.res14.TabIndex = 25;
            // 
            // res13
            // 
            this.res13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res13.Location = new System.Drawing.Point(281, 546);
            this.res13.Name = "res13";
            this.res13.Size = new System.Drawing.Size(121, 15);
            this.res13.TabIndex = 24;
            // 
            // res12
            // 
            this.res12.BackColor = System.Drawing.Color.White;
            this.res12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.res12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.res12.FormattingEnabled = true;
            this.res12.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.res12.Location = new System.Drawing.Point(281, 465);
            this.res12.Name = "res12";
            this.res12.Size = new System.Drawing.Size(121, 24);
            this.res12.TabIndex = 23;
            // 
            // res11
            // 
            this.res11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res11.Location = new System.Drawing.Point(281, 404);
            this.res11.Name = "res11";
            this.res11.Size = new System.Drawing.Size(121, 15);
            this.res11.TabIndex = 22;
            // 
            // res10
            // 
            this.res10.BackColor = System.Drawing.Color.White;
            this.res10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.res10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.res10.FormattingEnabled = true;
            this.res10.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.res10.Location = new System.Drawing.Point(281, 332);
            this.res10.Name = "res10";
            this.res10.Size = new System.Drawing.Size(121, 24);
            this.res10.TabIndex = 21;
            // 
            // res9
            // 
            this.res9.BackColor = System.Drawing.Color.White;
            this.res9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.res9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.res9.FormattingEnabled = true;
            this.res9.Items.AddRange(new object[] {
            "No",
            "Algunas veces",
            "Frecuentemente",
            "Siempre"});
            this.res9.Location = new System.Drawing.Point(281, 292);
            this.res9.Name = "res9";
            this.res9.Size = new System.Drawing.Size(121, 24);
            this.res9.TabIndex = 20;
            // 
            // res8
            // 
            this.res8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res8.Location = new System.Drawing.Point(281, 234);
            this.res8.Name = "res8";
            this.res8.Size = new System.Drawing.Size(121, 15);
            this.res8.TabIndex = 19;
            // 
            // res7
            // 
            this.res7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.res7.Location = new System.Drawing.Point(281, 170);
            this.res7.Name = "res7";
            this.res7.Size = new System.Drawing.Size(121, 15);
            this.res7.TabIndex = 6;
            // 
            // res6
            // 
            this.res6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.res6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.res6.FormattingEnabled = true;
            this.res6.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.res6.Location = new System.Drawing.Point(281, 97);
            this.res6.Name = "res6";
            this.res6.Size = new System.Drawing.Size(121, 24);
            this.res6.TabIndex = 18;
            // 
            // res5
            // 
            this.res5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.res5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.res5.FormattingEnabled = true;
            this.res5.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.res5.Location = new System.Drawing.Point(281, 35);
            this.res5.Name = "res5";
            this.res5.Size = new System.Drawing.Size(121, 24);
            this.res5.TabIndex = 6;
            this.res5.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 694);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tipo de transporte utilizado: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 647);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "¿Consume alcohol?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 48);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cantidad de horas que se \r\nutiliza artefactos electrónicos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 48);
            this.label8.TabIndex = 14;
            this.label8.Text = "Frecuencia de actividad \r\nfísica (días a la semana):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 48);
            this.label7.TabIndex = 13;
            this.label7.Text = "¿Monitorea las calorías \r\nque consumes?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 48);
            this.label6.TabIndex = 12;
            this.label6.Text = "Consumo diario de \r\nagua (en litros): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "¿Es fumador la persona?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "Consumo de comida entre\r\ndesayuno, almuerzo o cena: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 48);
            this.label3.TabIndex = 9;
            this.label3.Text = "Número de platos \r\nprincipales por día: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Frecuencia de consumo\r\nde vegetales:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Frecuencia de consumo \r\nde comida de altas calorías: ";
            // 
            // labelSobrePeso
            // 
            this.labelSobrePeso.AutoSize = true;
            this.labelSobrePeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSobrePeso.Location = new System.Drawing.Point(3, 11);
            this.labelSobrePeso.Name = "labelSobrePeso";
            this.labelSobrePeso.Size = new System.Drawing.Size(152, 48);
            this.labelSobrePeso.TabIndex = 6;
            this.labelSobrePeso.Text = "Presenta familiar \r\ncon sobrepeso: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Diagnóstico: ";
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.BackColor = System.Drawing.Color.White;
            this.respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.Location = new System.Drawing.Point(3, 29);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(0, 25);
            this.respuesta.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.respuesta);
            this.panel3.Location = new System.Drawing.Point(23, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 87);
            this.panel3.TabIndex = 30;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(743, 763);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelTalla;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.ComboBox res1;
        private System.Windows.Forms.TextBox res4;
        private System.Windows.Forms.TextBox res3;
        private System.Windows.Forms.TextBox res2;
        private System.Windows.Forms.Label labelSobrePeso;
        private System.Windows.Forms.ComboBox res5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox res6;
        private System.Windows.Forms.TextBox res7;
        private System.Windows.Forms.TextBox res8;
        private System.Windows.Forms.ComboBox res9;
        private System.Windows.Forms.ComboBox res10;
        private System.Windows.Forms.TextBox res11;
        private System.Windows.Forms.ComboBox res12;
        private System.Windows.Forms.TextBox res13;
        private System.Windows.Forms.TextBox res14;
        private System.Windows.Forms.ComboBox res15;
        private System.Windows.Forms.ComboBox res16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.Panel panel3;
    }
}

