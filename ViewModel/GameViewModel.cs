using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace ZH.ViewModel
{
    class GameViewModel : ViewModelBase
    {
        public ObservableCollection<Field> Fields { get; set; }
        Model _model;
        public DelegateCommand StartGameSmall { get; private set; }
        public DelegateCommand StartGameMedium { get; private set; }
        public DelegateCommand StartGameLarge { get; private set; }
        public DelegateCommand MoveUp { get; private set; }
        public DelegateCommand MoveDown { get; private set; }
        public DelegateCommand MoveLeft { get; private set; }
        public DelegateCommand MoveRight { get; private set; }
        public int BoardSize { get { return _model.Size; } }

        public EventHandler<int> StartGame;

        public GameViewModel(Model m)
        {
            _model = m;

            Fields = new ObservableCollection<Field>();
            StartGameSmall = new DelegateCommand(
                (_) => OnStartGame(4)
            );
            StartGameMedium = new DelegateCommand(
                (_) => OnStartGame(6)
            );
            StartGameLarge = new DelegateCommand(
                (_) => OnStartGame(8)
            );
            MoveUp = new DelegateCommand(
                (_) => _model.movePlayer(-1, 0)
            );
            MoveDown = new DelegateCommand(
                (_) => _model.movePlayer(1, 0)
            );
            MoveLeft = new DelegateCommand(
                (_) => _model.movePlayer(0, -1)
            );
            MoveRight = new DelegateCommand(
                (_) => _model.movePlayer(0, 1)
            );
            _model.generateTable += new EventHandler<int>(GenerateTable);
            _model.advanceTime += new EventHandler(RefreshTable);
        }


        private void OnStartGame(int e)
        {
            if (StartGame != null)
                StartGame(this, e);
        }

        private void GenerateTable(object sender, int e)
        {
            Fields.Clear();
            for (int i = 0; i < e; i++)
            {
                for (int j = 0; j < e; j++)
                {
                    string color = _model.getMapElem(i, j) == 0 ? "White" : _model.getMapElem(i, j) == 1 ? "Black" : "Blue";
                    Fields.Add(new Field
                    {
                        Text = String.Empty,
                        Color = color,
                        Type = _model.getMapElem(i, j),
                        X = i,
                        Y = j,
                        Number = i * _model.Size + j
                    });
                }
            }

            OnPropertyChanged("Fields");
        }
        private void RefreshTable(object sender, EventArgs e)
        {
            Fields.Clear();
            for (int i = 0; i < _model.Size; i++)
            {
                for (int j = 0; j < _model.Size; j++)
                {
                    string color = _model.getMapElem(i, j) == 0 ? "White" : _model.getMapElem(i, j) == 1 ? "Black" : "Blue";
                    Fields.Add(new Field
                    {
                        Text = String.Empty,
                        Color = color,
                        Type = _model.getMapElem(i, j),
                        X = i,
                        Y = j,
                        Number = i * _model.Size + j
                    });
                }
            }

            OnPropertyChanged("Fields");
            /*MessageBox.Show("REFRESH");
            Random rnd = new Random();

            foreach(Field f in Fields)
            {
                f.Type = _model.getMapElem(f.X, f.Y);
            }
            OnPropertyChanged("Fields");*/
        }

    }
}
