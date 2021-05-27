char incomingChar;
String inputString;
int ledpin = 4;
int sensorpin = A6;
int transistorval = 0;
bool stringComplete = false;

void setup() {
  Serial.begin(9600);
  pinMode(4, OUTPUT);
  digitalWrite(ledpin, LOW);
}

void loop() {
  readSensor();
  // reply only when you receive data:
  if (Serial.available() > 0) {
    readSerial();
  }

  if (stringComplete == true)
  {
    Serial.print("I received: ");
    Serial.print(inputString);
    
    if (inputString == "#ready\n") {
      Serial.println("ready");
    }
    else if(inputString.equals("#unready\n")){
      Serial.println("not ready");
    }
    inputString = "";
    stringComplete = false;
  }
      
}

void readSerial(){
    // read the incoming byte:
    incomingChar = char(Serial.read());
    // add it to a string
    inputString += incomingChar;

    if (incomingChar == '\n'){
      stringComplete = true;
    }
}

void readSensor(){
    transistorval = analogRead(sensorpin);
    Serial.println(transistorval);
    delay(100);
  }
