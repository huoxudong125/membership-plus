﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CryptoGateway.RDB.Data.MembershipPlus;

namespace Archymeta.Web.MembershipPlus.AppLayer.Models
{
    public class UserDetailsVM
    {
        public UserDetail Details
        {
            get { return _details; }
            set
            {
                _details = value;
                if (value != null)
                {
                    Gender = value.Gender;
                    if (value.BirthDate.HasValue)
                        BirthDate = value.BirthDate.Value.ToLocalTime();
                    else
                        BirthDate = null;
                    WebSiteUrl = value.WebsiteUrl;
                    Description = value.Description;
                }
            }

        }
        private UserDetail _details = null;

        public string Gender
        {
            get;
            set;
        }

        public string[] Genders
        {
            get;
            set;
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate
        {
            get;
            set;
        }

        public string WebSiteUrl
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public bool IsPhotoAvailable
        {
            get;
            set;
        }

        public CommunicationType[] ChannelTypes
        {
            get;
            set;
        }

        public List<dynamic> Channels
        {
            get { return _channels ?? (_channels = new List<dynamic>()); }
        }
        private List<dynamic> _channels = null;
    }
}
