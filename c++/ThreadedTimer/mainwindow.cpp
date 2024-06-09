#include "mainwindow.h"
#include "ui_mainwindow.h"

// @Author Tarik Vu (Tarikvu2@gmail.com)

// Constructor
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
    , thread(new QThread(this)) // Initialize QThread
    , timer(new QTimer(this)) // Initialize QTimer


{
    ui->setupUi(this);

    // Connect the Button w/ handleClicked()
    connect(ui->startStopButton, &QPushButton::clicked, this, &MainWindow::handleClicked);

    // Connect the timeout signal of the timer to a slot
    connect(timer, &QTimer::timeout, this, &MainWindow::updateTimerLabel);

}

// Destructor
MainWindow::~MainWindow()
{
    delete timer;
    delete thread;
    delete ui;
}


// Slot for our main button:
void MainWindow::handleClicked(){

    if(!thread->isRunning())
    {
        // Start the Thread and timer
        thread->start();
        timer->start(1);
        ui->startStopButton->setText("Stop");
    }
    else
    {
        // Stop the thread
        thread->quit(); // Stops the event loop
        thread->wait(); // Waits until the thread has terminated

        // Update the timer & UI
        timer->stop();
        ui->startStopButton->setText("Start");
    }
}

void MainWindow::updateTimerLabel(){

    // Increment time in ms
    ++timeElapsed;

    // Format Time
    // Note* Constant division calls can get expensive.
    int milliseconds = timeElapsed % 1000;
    int seconds = (timeElapsed / 1000) % 60;
    int minutes = (timeElapsed / 60000) % 24;
    int hours = (timeElapsed / 3600000) % 24;

    // Update the timer Label on UI
    ui->timerLabel->setText(QString("Hours: %1 | Minutes: %2 | Seconds: %3 | Milliseconds: %4")
                                .arg(hours)
                                .arg(minutes)
                                .arg(seconds)
                                .arg(milliseconds));
}
