﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorWOO.Pages
{
    public class post
    {
        public post(string para1, string img1)
        {
            Para1 = para1;
            Img1 = img1;
        }

        public post(string para1, string img1, string para2, string img2)
        {
            Para1 = para1;
            Img1 = img1;
            Para2 = para2;
            Img2 = img2;
        }

        public post(string para1, string img1, string para2, string img2, string para3, string im3)
        {
            Para1 = para1;
            Img1 = img1;
            Para2 = para2;
            Img2 = img2;
            Para3 = para3;
            Img3 = img3;
        }

        public post(string para1, string img1, string para2)
        {
            Para1 = para1;
            Img1 = img1;
            Para2 = para2;
        }

        public post(string para1, string img1, string para2, string img2, string para3, string im3, string para4)
        {
            Para1 = para1;
            Img1 = img1;
            Para2 = para2;
            Img2 = img2;
            Para3 = para3;
            Img3 = img3;
            Para4 = para4;
        }

        public post(string para1, string img1, string para2, string img2, string para3, string im3, string para4, string para5)
        {
            Para1 = para1;
            Img1 = img1;
            Para2 = para2;
            Img2 = img2;
            Para3 = para3;
            Img3 = img3;
            Para4 = para4;
            Para5 = para5;
        }

        public post(string para1, string img1, string para2, string img2, string para3, string im3, string para4, string para5, string para6)
        {
            Para1 = para1;
            Img1 = img1;
            Para2 = para2;
            Img2 = img2;
            Para3 = para3;
            Img3 = img3;
            Para4 = para4;
            Para5 = para5;
            Para6 = para6;
        }

       

        private string para1;

        public string Para1
        {
            get { return para1; }
            set { para1 = value; }
        }

        private string para2;

        public string Para2
        {
            get { return para2; }
            set { para2 = value; }
        }
        private string para3;

        public string Para3
        {
            get { return para3; }
            set { para3 = value; }
        }

        private string img1;

        public string Img1
        {
            get { return img1; }
            set { img1 = value; }
        }

        private string img2;

        public string Img2
        {
            get { return img2; }
            set { img2 = value; }
        }
        private string img3;

        public string Img3
        {
            get { return img3; }
            set { img3 = value; }
        }

        private string para4;

        public string Para4
        {
            get { return para4; }
            set { para4 = value; }
        }

        private string para5;

        public string Para5
        {
            get { return para5; }
            set { para5 = value; }
        }

        private string para6;

        public string Para6
        {
            get { return para6; }
            set { para6 = value; }
        }

        private string para7;

        public string Para7
        {
            get { return para7; }
            set { para7 = value; }
        }


    }
}
