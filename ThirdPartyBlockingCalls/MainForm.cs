using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdPartyBlockingCalls.ThirdPartyAssemblies;

namespace ThirdPartyBlockingCalls;

public partial class MainForm : Form
{
    #region variables and constructor
    BindingList<Car> _cars = new();
    private int _numberOfServicesToCall = 5;
    public MainForm()
    {
        InitializeComponent();
        lstCars.DataSource = _cars;
    } 
    #endregion

    #region Eventhandling
    private void btnGetCars_Click(object sender, EventArgs e) => GetCars();
    #endregion

    #region Single threaded
    private void GetCars()
    {
        DateTime begin = DateTime.Now;

        _cars.Clear();
        for (int i = 1; i <= _numberOfServicesToCall; i++)
        {
            //get the corresponding car service
            var carService = CarService.GetCarService(i);
            //add all the cars from that service to the list
            carService.GetCars().ToList().ForEach(car => AddCarWithInvokeIfNeeded(car));
        }

        int secondsTaken = (int)(DateTime.Now - begin).TotalSeconds;
        SetStatusLabel($"Retrieval took {secondsTaken} sec. {_cars.Count} cars in list");
    }
    #endregion

    #region Helper methods
    void SetStatusLabel(string message)
    {
        if (InvokeRequired)
        {
            this.Invoke((MethodInvoker)delegate () { SetStatusLabel(message); });
            return;
        }

        _cars.ResetBindings();

        toolStripStatusLabel1.Text = message;
    }


    private void AddCarWithInvokeIfNeeded(Car car)
    {
        if (InvokeRequired)
        {
            Invoke((MethodInvoker)delegate
            {
                _cars.Add(car);
            });
        }
        else { _cars.Add(car); }
    } 
    #endregion
}