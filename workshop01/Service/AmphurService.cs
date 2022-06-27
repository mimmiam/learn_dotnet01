using System;
using workshop01.Model;

namespace workshop01.Service
{
	public class AmphurService
	{
		private static AppDatabase Db;

        public AmphurService()
		{
			if(Db == null)
            {
				Db = new AppDatabase();
            }
        }

        public List<Amphurs> Get(int? id = null)
        {
            if(id != null )
            {
                return Db.Amphurs.Where(x => x.amphur_id == id).ToList();
            }
            return Db.Amphurs.ToList();
        }



        public void Create(int amphurId, string amphurName, int provinceId)
        {
            using(var entity = new AppDatabase() )
            {
                Amphurs temp = new Amphurs();
                temp.amphur_id = amphurId;
                temp.amphur_name = amphurName;
                temp.province_id = provinceId;
                entity.Amphurs.Add(temp);
                entity.SaveChanges();
            }
        }


        public void Update(int amphurId, string amphurName)
        { 
            var temp = Db.Amphurs.Where(x => x.amphur_id == amphurId).Single();
            temp.amphur_name = amphurName;
            Db.SaveChanges();
        }

        public void Delete(int amphurId)
        {
            var temp = Db.Amphurs.Where(x => x.amphur_id == amphurId).Single();
            Db.Amphurs.Remove(temp);
            Db.SaveChanges();
        }
    }
}

