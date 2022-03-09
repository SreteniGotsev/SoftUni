namespace _01._BrowserHistory
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using _01._BrowserHistory.Interfaces;

    public class BrowserHistory : IHistory
    {
        private List<ILink> history;

        public BrowserHistory()
        {
            history = new List<ILink>();
        }


        public int Size => history.Count;

        public void Clear()
        {
            history.Clear();
        }

        public bool Contains(ILink link)
        {
            return history.Contains(link);
        }

        public ILink DeleteFirst()
        {

            if (!(history.Count > 0))
            {
                throw new InvalidOperationException();
            }
            var temp = history[0];
            history.RemoveAt(0);

            return temp;
        }

        public ILink DeleteLast()
        {
            if (!(history.Count > 0))
            {
                throw new InvalidOperationException();
            }
            var temp = history[history.Count - 1];
            history.RemoveAt(history.Count - 1);

            return temp;
        }

        public ILink GetByUrl(string url)
        {

            foreach (var item in history)
            {
                if (item.Url == url)
                {
                    return item;
                }
            }

            return null;
        }

        public ILink LastVisited()
        {
            if (!(history.Count > 0))
            {
                throw new InvalidOperationException();
            }

            return history[history.Count - 1];
        }

        public void Open(ILink link)
        {
            history.Add(link);
        }

        public int RemoveLinks(string url)
        {
            int count = 0;

            foreach (var item in history)
            {
                if (item.Url.Contains(url))
                {
                    count++;
                }
            }
            history.RemoveAll(x => x.Url.Contains(url));

            if (count == 0)
            {
                throw new InvalidOperationException();
            }

            return count;
        }

        public ILink[] ToArray()
        {

            history.Reverse();

            return history.ToArray();
        }

        public List<ILink> ToList()
        {
            history.Reverse();

            return history;
        }

        public string ViewHistory()
        {
            if (history.Count == 0)
            {
                return "Browser history is empty!";
            }
            history.Reverse();

            StringBuilder str = new StringBuilder();

            foreach (var item in history)
            {
                str.AppendLine(item.ToString());
            }
            return str.ToString();
            //return string.Join(Environment.NewLine, history);
        }
    }
}
