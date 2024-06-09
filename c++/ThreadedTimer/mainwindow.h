#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QThread>
#include <QTimer>
#include <QTime>
#include <QPushButton>

// @Author Tarik Vu (Tarikvu2@gmail.com)

QT_BEGIN_NAMESPACE
namespace Ui {
class MainWindow;
}
QT_END_NAMESPACE


// Main Class:
class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    // Constructor
    MainWindow(QWidget *parent = nullptr);

    // Destructor
    ~MainWindow();

private slots:
    // Main functions for mainwindow.cpp
    void handleClicked();
    void updateTimerLabel();

private:

    Ui::MainWindow *ui;
    QThread *thread;
    QTimer *timer;
    int timeElapsed = 0;
};

#endif // MAINWINDOW_H
