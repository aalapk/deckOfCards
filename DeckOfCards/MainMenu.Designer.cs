namespace DeckOfCardsDemo
{
    partial class MainMenu
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
            this.deck = new System.Windows.Forms.ListBox();
            this.drawACard = new System.Windows.Forms.Button();
            this.returnCardsToDeck = new System.Windows.Forms.Button();
            this.shuffle = new System.Windows.Forms.Button();
            this.cardsDrawn = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deckCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deck
            // 
            this.deck.FormattingEnabled = true;
            this.deck.Location = new System.Drawing.Point(446, 63);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(147, 693);
            this.deck.TabIndex = 0;
            // 
            // drawACard
            // 
            this.drawACard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawACard.Location = new System.Drawing.Point(52, 78);
            this.drawACard.Name = "drawACard";
            this.drawACard.Size = new System.Drawing.Size(128, 59);
            this.drawACard.TabIndex = 1;
            this.drawACard.Text = "Draw A Card";
            this.drawACard.UseVisualStyleBackColor = true;
            this.drawACard.Click += new System.EventHandler(this.drawACard_Click);
            // 
            // returnCardsToDeck
            // 
            this.returnCardsToDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnCardsToDeck.Location = new System.Drawing.Point(52, 174);
            this.returnCardsToDeck.Name = "returnCardsToDeck";
            this.returnCardsToDeck.Size = new System.Drawing.Size(128, 59);
            this.returnCardsToDeck.TabIndex = 2;
            this.returnCardsToDeck.Text = "Return Drawn Cards to Deck";
            this.returnCardsToDeck.UseVisualStyleBackColor = true;
            this.returnCardsToDeck.Click += new System.EventHandler(this.returnCardsToDeck_Click);
            // 
            // shuffle
            // 
            this.shuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffle.Location = new System.Drawing.Point(52, 272);
            this.shuffle.Name = "shuffle";
            this.shuffle.Size = new System.Drawing.Size(128, 59);
            this.shuffle.TabIndex = 3;
            this.shuffle.Text = "Shuffle";
            this.shuffle.UseVisualStyleBackColor = true;
            this.shuffle.Click += new System.EventHandler(this.shuffle_Click);
            // 
            // cardsDrawn
            // 
            this.cardsDrawn.FormattingEnabled = true;
            this.cardsDrawn.Location = new System.Drawing.Point(261, 63);
            this.cardsDrawn.Name = "cardsDrawn";
            this.cardsDrawn.Size = new System.Drawing.Size(147, 693);
            this.cardsDrawn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Drawn Cards";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deck";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Count = ";
            // 
            // deckCount
            // 
            this.deckCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deckCount.Location = new System.Drawing.Point(576, 48);
            this.deckCount.Name = "deckCount";
            this.deckCount.ReadOnly = true;
            this.deckCount.Size = new System.Drawing.Size(17, 13);
            this.deckCount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Deck of Cards Demo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 49);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Commands Menu";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 772);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deckCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardsDrawn);
            this.Controls.Add(this.shuffle);
            this.Controls.Add(this.returnCardsToDeck);
            this.Controls.Add(this.drawACard);
            this.Controls.Add(this.deck);
            this.Name = "MainMenu";
            this.Text = "Deck Of Cards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox deck;
        private System.Windows.Forms.Button drawACard;
        private System.Windows.Forms.Button returnCardsToDeck;
        private System.Windows.Forms.Button shuffle;
        private System.Windows.Forms.ListBox cardsDrawn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deckCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

