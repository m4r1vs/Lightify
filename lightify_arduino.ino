const int redPin = 3;
const int greenPin = 6;
const int bluePin = 5;
int r_o = 0, g_o = 0, b_o = 0;
int r_b = 0, g_b = 0, b_b = 0;
int r_dif, g_dif, b_dif;
int first = 0;

void setup() {

  Serial.begin(9600);

  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);

  for (int r = 0; r < 256; r++) { 
    analogWrite(redPin, r);
    delay(2);
  }

  delay(100);

  for (int r = 256; r > 0; r--) { 
    analogWrite(redPin, r);
    delay(2);
  } 
}

void loop() {

  // if there's any serial available, read it:
  while (Serial.available() > 0) {

    int red = Serial.parseInt();
    int green = Serial.parseInt();
    int blue = Serial.parseInt();
    int state = Serial.parseInt();

    if (state == 1) {
      if (Serial.read() == '\n') {
        if (red <= 255 && green <= 255 && blue <= 255) {
          setColor(red, green, blue, 2);
        } else if (red == 300 && green == 300 && blue == 300) {
          fade(20);
        } else if (red == 301 && green == 301 && blue == 301) {
          party(500);
        } else if (red == 302 && green == 302 && blue == 302) {
          r_b = r_o;
          g_b = g_o;
          b_b = b_o;
          setColor(0,0,0,2);
          breathe(100);
        } else {
          delay(2);
        }
      }
    } else if (state == 0) {
      if (Serial.read() == '\n') {
        if (red <= 255 && green <= 255 && blue <= 255) {
          if (first == 0) {
            first = 1;
          }
          analogWrite(redPin, red);
          analogWrite(greenPin, green);
          analogWrite(bluePin, blue);
        }
      }
    }
  }
}

void setColor(int r_n, int g_n, int b_n, int fadespeed) {

  if (first == 1) {
    first = 0;
    r_o = 0;
    g_o = 0;
    b_o = 0;
    analogWrite(redPin, 0);
    analogWrite(greenPin, 0);
    analogWrite(bluePin, 0);
  }

  if (r_o >= r_n) {
    r_dif = r_o - r_n;
  } else {
    r_dif = r_n - r_o;
  }
  if (g_o >= g_n) {
    g_dif = g_o - g_n;
  } else {
    g_dif = g_n - g_o;
  }
  if (b_o >= b_n) {
    b_dif = b_o - b_n;
  } else {
    b_dif = b_n - b_o;
  }

  for (int i = 1; i < 256; i++) {
    if (r_o >= r_n) {
      r_o = r_o - round(double(r_dif)/255);
      analogWrite(redPin, r_o);
    } else {
      r_o = r_o + round(double(r_dif)/255);
      analogWrite(redPin, r_o);
    }
    if (g_o >= g_n) {
      g_o = g_o - round(double(g_dif)/255);
      analogWrite(greenPin, g_o);
    } else {
      g_o = g_o + round(double(g_dif)/255);
      analogWrite(greenPin, g_o);
    }
    if (b_o >= b_n) {
      b_o = b_o - round(double(b_dif)/255);
      analogWrite(bluePin, b_o);
    } else {
      b_o = b_o + round(double(b_dif)/255);
      analogWrite(bluePin, b_o);
    }
    delay(fadespeed);
  }

}

void fade(int fadespeed) {
  while (true) {
    setColor(255,0,0,fadespeed);
    if (Serial.available() > 0) {
      break;
    }
    setColor(255,255,0,fadespeed);
    if (Serial.available() > 0) {
      break;
    }
    setColor(0,255,0,fadespeed);
    if (Serial.available() > 0) {
      break;
    }
    setColor(0,255,255,fadespeed);
    if (Serial.available() > 0) {
      break;
    }
    setColor(0,0,255,fadespeed);
    if (Serial.available() > 0) {
      break;
    }
    setColor(255,0,255,fadespeed);
    if (Serial.available() > 0) {
      break;
    }
  }
}

void party(int partyspeed) {
  while (true) {
    if (first == 0) {
      first = 1;
    }
    //Red
    analogWrite(redPin, 255);
    analogWrite(greenPin, 0);
    analogWrite(bluePin, 0);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Cyan
    analogWrite(redPin, 0);
    analogWrite(greenPin, 255);
    analogWrite(bluePin, 255);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Rasperry
    analogWrite(redPin, 255);
    analogWrite(greenPin,0);
    analogWrite(bluePin, 125);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Turquoise
    analogWrite(redPin, 0);
    analogWrite(greenPin, 255);
    analogWrite(bluePin, 125);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Magenta
    analogWrite(redPin, 255);
    analogWrite(greenPin, 0);
    analogWrite(bluePin, 255);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Green
    analogWrite(redPin, 0);
    analogWrite(greenPin, 255);
    analogWrite(bluePin, 0);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Violet
    analogWrite(redPin, 125);
    analogWrite(greenPin, 0);
    analogWrite(bluePin, 255);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Spring Green
    analogWrite(redPin, 125);
    analogWrite(greenPin, 255);
    analogWrite(bluePin, 0);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Blue
    analogWrite(redPin, 0);
    analogWrite(greenPin, 0);
    analogWrite(bluePin, 255);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Yellow
    analogWrite(redPin, 255);
    analogWrite(greenPin, 255);
    analogWrite(bluePin, 0);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Ocean
    analogWrite(redPin, 0);
    analogWrite(greenPin, 125);
    analogWrite(bluePin, 255);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Orange
    analogWrite(redPin, 255);
    analogWrite(greenPin, 125);
    analogWrite(bluePin, 0);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
    //Cyan
    analogWrite(redPin, 0);
    analogWrite(greenPin, 255);
    analogWrite(bluePin, 255);
    delay(partyspeed);
    if (Serial.available() > 0) {
      break;
    }
  }
}

void breathe(int breathespeed) {
  while (true) {
    setColor(r_b,g_b,b_b,breathespeed/20);
    delay(breathespeed/2);
    if (Serial.available() > 0) {
      break;
    }
    setColor(0,0,0,breathespeed/20);
    delay(breathespeed*10);
    if (Serial.available() > 0) {
      break;
    }
  }
}

