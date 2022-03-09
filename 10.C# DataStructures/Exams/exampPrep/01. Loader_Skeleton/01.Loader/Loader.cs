namespace _01.Loader
{
    using _01.Loader.Interfaces;
    using _01.Loader.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Loader : IBuffer
    {
        public Loader()
        {
            entities = new List<IEntity>();
            parents = new Dictionary<int, List<IEntity>>();
        }

        List<IEntity> entities;
        Dictionary<int, List<IEntity>> parents;



        public int EntitiesCount => entities.Count;

        public void Add(IEntity entity)
        {
            entities.Add(entity);
            if (!parents.ContainsKey(entity.Id))
            {
                parents.Add(entity.Id, new List<IEntity>());
            }

            parents[entity.Id].Add(entity);
        }

        public void Clear()
        {
            entities.Clear();
            parents.Clear();
        }

        public bool Contains(IEntity entity)
        {
            if (parents.ContainsKey(entity.Id))
            {
                return true;
            }

            return false;
        }

        public IEntity Extract(int id)
        {
            if (parents.ContainsKey(id))
            {
                var temp = entities[id];
                parents.Remove(id);
                entities.RemoveAt(id);
                return temp;
            }

            return null;
        }

        public IEntity Find(IEntity entity)
        {
            if (parents.ContainsKey(entity.Id))
            {
                return entities[entity.Id];
            }

            return null;
        }

        public List<IEntity> GetAll()
        {
            List<IEntity> list = new List<IEntity>();

            if (entities.Count != 0)
            {
                list = entities;
                return list;
            }

            return list;
        }

        public IEnumerator<IEntity> GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        public void RemoveSold()
        {

            List<IEntity> list = new List<IEntity>();
            foreach (IEntity item in entities)
            {
                var status = item.Status;

                if (status != BaseEntityStatus.Sold)
                {
                    list.Add(item);

                }
            }

            entities = list;
        }

        public void Replace(IEntity oldEntity, IEntity newEntity)
        {
            int index = entities.IndexOf(oldEntity);

            //if (index >= 0)
            //{
            entities[index] = newEntity;
            //   return;
            // }



            // throw new InvalidOperationException("Entity not found");
        }


        public List<IEntity> RetainAllFromTo(BaseEntityStatus lowerBound, BaseEntityStatus upperBound)
        {
            List<IEntity> list = new List<IEntity>();

            foreach (var item in entities)
            {

                if (item.Status >= lowerBound && item.Status <= upperBound)
                {
                    list.Add(item);
                }


            }

            return list;
        }

        public void Swap(IEntity first, IEntity second)
        {
            int index = entities.IndexOf(first);
            int secondIndex = entities.IndexOf(second);

            if (index > 0 && secondIndex > 0)
            {
                var temp = entities[index];
                entities[index] = second;
                entities[secondIndex] = temp;

            }
            else
            {
                throw new InvalidOperationException("Entity not found");
            }
        }

        public IEntity[] ToArray()
        {
            return entities.ToArray();
        }

        public void UpdateAll(BaseEntityStatus oldStatus, BaseEntityStatus newStatus)
        {
            foreach (var item in entities)
            {
                if (item.Status == oldStatus)
                {
                    item.Status = newStatus;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
