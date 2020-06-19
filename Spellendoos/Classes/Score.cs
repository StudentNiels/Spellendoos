using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Documents;

namespace Spellendoos.Classes
{
    public class Score : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Player> players;
        private Player selectedPlayer;

        public Score()
        {
            players = MainWindow.getPlayers();
        }

        public List<Player> PlayerList
        {
            get { return players; }
            set { players = value;
                NotifyPropertyChanged();
            }
        }

        public Player SelectedPlayer
        {
            get { return selectedPlayer; }
            set { selectedPlayer = value;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
