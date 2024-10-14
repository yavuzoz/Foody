﻿using Foody.Businesslayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Businesslayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal FeatureDal)
        {
            _featureDal = FeatureDal;
        }
        public void TDelete(int id)
        {
            _featureDal.Delete(id);
        }
        public List<Feature> TGetAll()
        {
            return _featureDal.GetAll();
        }
        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }
        public void TInsert(Feature entity)
        {
            _featureDal.Insert(entity);
        }
        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
