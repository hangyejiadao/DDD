﻿using ESTM.Infrastructure.MEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using ESTM.Domain;
using System.ComponentModel.Composition.Hosting;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Configuration;

namespace ESTM.WCF.Service
{
    class Program
    {

        //[Import]
        //public IUserRepository userRepository { get; set; }

        //[Import]
        //public IMenuRepository menuRepository { get; set; }

        //[Import]
        //public IPowerManagerDomainService powerDomainService { get; set; }
        static void Main(string[] args)
        {
            //var oProgram = new Program();
            //Regisgter.regisgter().ComposeParts(oProgram);
            //var lstMenu = oProgram.menuRepository.Entities.ToList();
            //var oUser = new TB_USERS() { USER_ID = "04acd48a819447d388b20dffb15f672e" };
            //var oRole = new TB_ROLE() { ROLE_ID = "cccc" };
            //oProgram.powerDomainService.AssignPower(oUser, oRole);
            //PowerManageWCFService oTest = new PowerManageWCFService();
            //var lstRes = oTest.GetUsers(x => x.USER_NAME == "dfd");

            var oBootstrapper = new Bootstrapper();
            oBootstrapper.StartServices();
           
            Console.ReadKey();
        }

        

    }
}
