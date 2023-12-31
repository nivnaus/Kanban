﻿using Frontend.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace Frontend.ViewModel

{
    internal class BoardViewModel : NotifiableObject
    {
        private BackendController controller;
        private BoardControllerModel boardController;
        public BoardModel Board { get; private set; }
        public SolidColorBrush BackgroundColor
        {
            get
            {
                return new SolidColorBrush(Board.BoardName.Equals("board1") ? Colors.Blue : Colors.Red);
            }
        }

        public string Title { get; private set; }
        private ObservableCollection<TaskModel> _backLogTasks;
        private ObservableCollection<TaskModel> _inProgressTasks;
        private ObservableCollection<TaskModel> _doneTasks;

        public BoardViewModel(BoardModel board)
        {
            this.Board = board;
            Title = "Board view for " + board.BoardName;
            _backLogTasks = board.Tasks_backlog;
            _inProgressTasks = board.Tasks_backlog;
            _doneTasks = board.Tasks_done;
        }

    }
}