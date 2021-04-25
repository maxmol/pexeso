using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pexeso {
	public partial class Form1 : Form {
		// možné stavy hry
		public enum Page {
			Start,
			Hra,
			Konec
		};
		
		private static int gameSize = 6;
		
		// promenna stavu
		private Page page;
		private int pocetTahu = 0;
		private int[] randomizedNumbers;
		private HashSet<Button> cards = new HashSet<Button>();
		private Button selectedCard = null;
		private bool blockCardClick = false;

		private Dictionary<Page, HashSet<Control>> pagesContent = new Dictionary<Page, HashSet<Control>>();
		
		public Form1() {
			Random random = new Random();
			randomizedNumbers = Enumerable.Range(0, gameSize * gameSize)
				.OrderBy(x => random.Next()).ToArray();

			InitializeComponent();

			setPageContent(Page.Start, bStart, LNavod);
			setPageContent(Page.Hra, bKonec, LPocetTahu);
			setPageContent(Page.Konec, bHratZnovu, LVysledek);

			setPage(Page.Start);
		}
		
		// funkce kde uvedu elementy, které se zobrazí ve stavu `page`
		private void setPageContent(Page page, params Control[] controls) {
			pagesContent.Add(page, new HashSet<Control>(controls));
		}

		// funce nastavení stavu
		public void setPage(Page page) {
			var visibleControls = pagesContent[page];
			foreach (Control control in Controls) {
				control.Visible = visibleControls.Contains(control);
			}

			if (page == Page.Hra) {
				pocetTahu = 0;
				LPocetTahu.Text = "Počet tahů : 0";
				createCards();
			}
			else
				removeCards();

			this.page = page;
		}

		private void bStartClick(object b, EventArgs eventArgs) {
			setPage(Page.Hra);
		}
		
		private void bHratZnovu_Click(object b, EventArgs eventArgs) {
			setPage(Page.Hra);
		}
		
		private void bKonecClick(object b, EventArgs eventArgs) {
			LVysledek.Text = "Konec hry";
			setPage(Page.Konec);
		}
		
		// funkce vytvaření kartiček
		private void createCards() {
			if (cards.Count == 0) {
				int width = (ClientRectangle.Width - 286) / gameSize;
				int height = (ClientRectangle.Height - 24) / gameSize;

				for (int i = 0; i < gameSize; i++)
					for (int j = 0; j < gameSize; j++) {
						Button b = new Button();
						b.Width = width;
						b.Height = height;
						b.Left = i * width + 12;
						b.Top = j * height + 12;
						b.Text = "";
						b.Tag = randomizedNumbers[gameSize * i + j] / 2 + 1;
						b.Font = bStart.Font;
						b.BackColor = Color.Gray;
						b.Click += cardClickEvent;
						Controls.Add(b);
						cards.Add(b);
					}
			}
		}
		
		private void removeCards() {
			foreach (Button button in cards) {
				Controls.Remove(button);
				button.Dispose();
			}
			
			cards.Clear();
		}

		// zkontroluju, zda byly uhádnuty všechny kartičky
		private bool allCardsFlipped() {
			foreach (var b in cards) {
				if (b.Enabled)
					return false;
			}

			return true;
		}
		
		private void cardClickEvent(object obj, EventArgs eventArgs) {
			if (blockCardClick) return;

			Button b = (Button) obj;

			if (selectedCard == b) return;
			
			b.Text = b.Tag.ToString();
			b.BackColor = Color.FloralWhite;
			
			if (selectedCard == null) {
				selectedCard = b;
			}
			else {
				pocetTahu++;
				LPocetTahu.Text = "Počet tahů : " + pocetTahu;
				
				if ((int) selectedCard.Tag == (int) b.Tag) {
					selectedCard.Click -= cardClickEvent;
					b.Click -= cardClickEvent;
					b.Enabled = false;
					selectedCard.Enabled = false;
				}
				else {
					noMatch(selectedCard, b);
					blockCardClick = true;
				}

				selectedCard = null;
			}

			if (allCardsFlipped()) {
				LVysledek.Text = "Počet tahů\n▶" + pocetTahu + "◀";
				setPage(Page.Konec);
			}
		}

		private async void noMatch(Button b1, Button b2) {
			b1.BackColor = Color.LightCoral;
			b2.BackColor = Color.LightCoral;
			
			await Task.Delay(500);
			b1.Text = "";
			b2.Text = "";
			b1.BackColor = Color.Gray;
			b2.BackColor = Color.Gray;
			blockCardClick = false;
		}
	}
}