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

        public List<AmphurModel> Get(int? id = null)
        {
            if(id != null )
            {
                return Db.AmphurModel.Where(x => x.amphur_id == id).ToList();
            }
            return Db.AmphurModel.ToList();
        }



        public void Create(int amphurId, string amphurName, int provinceId)
        {
            using(var entity = new AppDatabase() )
            {
                AmphurModel temp = new AmphurModel();
                temp.amphur_id = amphurId;
                temp.amphur_name = amphurName;
                temp.province_id = provinceId;
                entity.AmphurModel.Add(temp);
                entity.SaveChanges();
            }
        }


        public void Update(int amphurId, string amphurName)
        { 
            var temp = Db.AmphurModel.Where(x => x.amphur_id == amphurId).Single();
            temp.amphur_name = amphurName;
            Db.SaveChanges();
        }

        public void Delete(int amphurId)
        {
            var temp = Db.AmphurModel.Where(x => x.amphur_id == amphurId).Single();
            Db.AmphurModel.Remove(temp);
            Db.SaveChanges();
        }
    }
}

