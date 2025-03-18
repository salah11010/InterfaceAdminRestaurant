﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using InterfaceAdminRestaurant;

namespace InterfaceAdminRestaurant
{
    /// <summary>
    /// Interaction logic for Identification.xaml
    /// </summary>
    public partial class Identification : Page
    {
        public Identification()
        {
            InitializeComponent();
        }


        public void Login(object sender, RoutedEventArgs e)
        {
            string nomRestaurant = NomRestaurantTextBox.Text;
            string motDePasse = MotDePasseTextBox.Text;
            bool verifie = Restaurant.VerifierRestaurant(nomRestaurant, motDePasse);
            if (verifie)
            {
                MessageBox.Show("accès autoriser.");
            }
            else
            {
                MessageBox.Show("vérifiez vos informations.");
            }
        }


    }
}
