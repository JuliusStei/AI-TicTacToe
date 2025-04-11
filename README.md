# AI-TicTacToe
Tic Tac Toe Opponent trained with AI (Q-Learning)

# Entwicklung einer künstlichen Intelligenz für TicTacToe

**Julius Steinbach (977271)**  
Modul: KI für Spiele  
Betreuer: Prof. Dr. Christof Rezk-Salama  
Trier, 15.02.2025

## 1 Motivation

Tic-Tac-Toe gilt als eines der simpelsten Spiele, bietet jedoch eine überraschende mathematische Komplexität und eignet sich hervorragend zur Untersuchung der Anwendung von künstlicher Intelligenz (KI) in der Spieleentwicklung. Mit über 5500 möglichen Spielzuständen erfordert das Spiel eine durchdachte Strategie, um optimale Entscheidungen zu treffen.

Ziel dieses Projekts war die Entwicklung einer KI, die auf einem menschlichen Niveau spielt. Die KI sollte aus Erfahrungen lernen und auf dieser Basis Entscheidungen treffen. Der Fokus lag auf der Implementierung des Q-Learning-Algorithmus, einem Reinforcement-Learning-Ansatz, der durch Belohnungen und Bestrafungen das Lernen ermöglicht. Die Leistung der KI wurde anhand objektiver Kriterien wie Sieg- und Niederlagestatistiken bewertet.

Das persönliche Ziel bestand darin, das Verständnis für KI-Entwicklung zu vertiefen und vorhandenes Wissen in einer praktischen Anwendung zu testen.

## 1.1 Softwarearchitektur

### 1.1.1 Score

Die Klasse `Score` speichert und verwaltet Spielergebnisse. Sie zählt Siege, Niederlagen und Unentschieden für beide Spieler sowie die Gesamtanzahl der Partien. Sie dient zur Verfolgung des KI-Fortschritts während Training und Evaluation.

### 1.1.2 GameBoard

Die Klasse `GameBoard` repräsentiert das Spielfeld mittels eines zweidimensionalen Arrays.

**Funktionen:**
- `Konstruktor`: Erstellt ein leeres oder vordefiniertes Spielfeld
- `SetFieldPosition(x, y, tile)`
- `GetFieldPosition(x, y)`
- `CheckEmpty(x, y)`
- `EmptyBoard()`

### 1.1.3 Game

Die Klasse `Game` verwaltet den Spielablauf und implementiert `IGameState`.

**Wichtige Methoden:**
- `Move()`: Führt einen Zug aus und bewertet ihn.
- `PossibleActions()`: Gibt mögliche Züge zurück.
- `HasWon()` und `HasDrawn()`: Prüfen den Spielstand.
- `Id`: Eindeutige Repräsentation des Zustands.
- `ExecuteAction()`, `CheckValidTileCount()`, `Reset()`

### 1.1.4 MainWindow

`MainWindow` bildet das Spielbrett ab und ermöglicht die KI-Konfiguration.

**Funktionen:**
- Drei Spielmodi: Player vs AI, AI vs AI, Player vs Random
- Analysefunktion mit grafischer Darstellung
- „AI-Evaluation“-Modus zur KI-Bewertung

## 1.2 Spielmodi

### 1.2.1 AI vs AI

Trainiert beide KIs durch wiederholtes Spielen.

**Konfiguration:**
- `Number of Iterations`
- `Discount Rate`
- `Reward for Win`, `Reward for Possible Win`, `Reward for Possible Loss`

**Ablauf:**
- `Train` startet das Training
- `LearnStep()` wird periodisch aufgerufen
- Fortschritt per Progress Bar visualisiert

**Evaluation:**
Nach dem Training analysiert der AI-Evaluation-Modus die Leistung durch Spielstatistiken.

### AI vs Random

Dient zur Bewertung gegen zufällige Gegner.

**Ablauf:**
- Gegner wählt Züge zufällig
- Spieltempo erhöht
- Nur verfügbar nach Training im AI vs AI-Modus

### 1.2.2 Player vs AI

Ermöglicht dem Nutzer das direkte Spiel gegen die KI.

**Ablauf:**
- Nutzer klickt Spielfeld → `ClickTile()`
- KI-Zug über `LearnStep()`
- Nach Spielende: Reset und Neustart

## 1.3 Analyse der Ergebnisse

### 1.3.1 Gegen zufälligen Gegner

- Training: 100.000 Iterationen
- Konfiguration:
  - Reward for Win: 1
  - Discount Rate: 0,75
  - Reward for Possible Win: 0,6
  - Reward for Possible Loss: -1

**Ergebnis:**  
- 4900 Spiele: 4392 Siege, 97 Niederlagen → 87 % Siegquote

### 1.3.2 Zwei KIs gegeneinander

- 2700 Spiele: 2097 Unentschieden → Ausgeglichenes Verhalten

### 1.3.3 Einfluss der Iterationen

- 1.000 Iterationen: 63 %
- 100.000 Iterationen: 87 %
- 1.000.000 Iterationen: 92 %

Erhöhte Iterationen verbessern das Spielverhalten signifikant.

## 1.4 Reflexion

Die KI zeigt hohe Lernfähigkeit und strategisches Verhalten. Besonders hervorzuheben ist die deutliche Leistungssteigerung mit zunehmendem Training. Eine Feinabstimmung der Belohnungsparameter könnte zukünftige Verbesserungen bringen. Das Projekt hat sowohl technische Fähigkeiten als auch Verständnis für komplexe KI-Konzepte vertieft.

