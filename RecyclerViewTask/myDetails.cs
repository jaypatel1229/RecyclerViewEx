using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecyclerViewTask
{
    public class myDetails
    {
        public myDetails(int id, string name, string description)
        {

            PhotoId = id;
            Name = name;
            Description = description;
        }     

        public int PhotoId { get; }
        public string Name { get; }
        public string Description { get; }
    }

    public class myDetailsViewModel
    {
        static myDetails[] details = {                                        // List  of Details
            new myDetails(Resource.Drawable.ic_bank,"Aman","Founder"),
            new myDetails(Resource.Drawable.ic_bike,"Mayank","Saler"),
            new myDetails(Resource.Drawable.ic_Dress,"Nila","Designer"),
            new myDetails(Resource.Drawable.ic_gym,"Ankit","Trainner"),
            new myDetails(Resource.Drawable.ic_heart,"Nikita","Decorater"),
            new myDetails(Resource.Drawable.ic_home,"Akash","Architacter"),
            new myDetails(Resource.Drawable.ic_Hotel,"Himen","Manager"),
            new myDetails(Resource.Drawable.ic_bank,"Aman","Founder"),
            new myDetails(Resource.Drawable.ic_bike,"Mayank","Saler"),
            new myDetails(Resource.Drawable.ic_Dress,"Nila","Designer"),
            new myDetails(Resource.Drawable.ic_gym,"Ankit","Trainner"),
            new myDetails(Resource.Drawable.ic_heart,"Nikita","Decorater"),
            new myDetails(Resource.Drawable.ic_home,"Akash","Architacter"),
            new myDetails(Resource.Drawable.ic_Hotel,"Himen","Manager"),
            new myDetails(Resource.Drawable.ic_bank,"Aman","Founder"),
            new myDetails(Resource.Drawable.ic_bike,"Mayank","Saler"),
            new myDetails(Resource.Drawable.ic_Dress,"Nila","Designer"),
            new myDetails(Resource.Drawable.ic_gym,"Ankit","Trainner"),
            new myDetails(Resource.Drawable.ic_heart,"Nikita","Decorater"),
            new myDetails(Resource.Drawable.ic_home,"Akash","Architacter"),
            new myDetails(Resource.Drawable.ic_Hotel,"Himen","Manager"),
            new myDetails(Resource.Drawable.ic_bank,"Aman","Founder"),
            new myDetails(Resource.Drawable.ic_bike,"Mayank","Saler"),
            new myDetails(Resource.Drawable.ic_Dress,"Nila","Designer"),
            new myDetails(Resource.Drawable.ic_gym,"Ankit","Trainner"),
            new myDetails(Resource.Drawable.ic_heart,"Nikita","Decorater"),
            new myDetails(Resource.Drawable.ic_home,"Akash","Architacter"),
            new myDetails(Resource.Drawable.ic_Hotel,"Himen","Manager")
        };

        private myDetails[] myDetails;

        public myDetailsViewModel() // Constructor of myDetailsViewModel
        {
            myDetails = details;  
        }

        public int NumberFriend
        {
            get { return myDetails.Length; } // Return length of myDetails
        }

        public myDetails this[int i]
        {
            get { return myDetails[i]; } // Return Index Position of myDetails
        }
    }
}