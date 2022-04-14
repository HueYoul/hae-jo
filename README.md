# hae-jo
# Let me bounce

# 1. 개요

### 1-1. 프로젝트의 목표 및 개요
저희는 기존 바운스볼이라는 게임에서 이 게임을 색다르게 만들어보면 어떨가 생각하여 let me bounce라는 게임을 만들려고 합니다.

기존 바운스볼은 좌우 터치를 통하여 조작하고, 혼자서 하는 게임이었다면, 저희가 만들 게임은 Android 가속도계 기울기와 협동모드를 추가하여 
더욱 재미있는 조작감과 협동의 재미를 줄 수 있는 게임을 만들려고 합니다.

### 1-2. 사용 프로그램 및 언어
Unity (2020.3.27f1)

Photon

C#

### 1-3. 게임 규칙
두명의 유저가 협동해야하는 멀티게임이며 두 유저가 공을 각각 하나씩 갖고 함정들을 피해 서로 협동하여 별을 모두 획득하면 클리어합니다.

# 2. 진행 과정

### 2-1. 개발 목표
12월 ~ 2월 : 게임베이스 구현

2월 ~ 3월 : Android 기울기 추가

3월 ~ : 서버개발

### 2-2. 개발 과정

#### 2022.03.18
특수 블록을 하나 구현했다.
밟으면 다른 키를 누르기 전까지 화살표 방향으로 쭉 간다.


![ezgif com-gif-maker (2)](https://user-images.githubusercontent.com/92212636/160977451-81c74a8a-475b-4416-a2bd-58074c1530ac.gif)





#### 2022.03.19
게임베이스 및 함정을 구현하였다.
가시 블록을 밟으면 공이 없어진다.
이후에 공이 없어지고 리스폰 되는것을 구현할 예정이다.



![ezgif com-gif-maker](https://user-images.githubusercontent.com/92212636/160977466-d54176a4-6f1c-48a5-9685-80eba2145435.gif)





#### 2022.03.23
간단한 서버 구축완료하였다.
처음이라 굉장히 애를 먹었지만 그래도 성공한 것에 매우 기쁘다.

#### 2022.03.26
오늘은 기울기를 추가하여 모바일로 실행시켜 봤다.
핸드폰을 기울이면 움직이긴 하지만 이상하게 공이 튀기는 높이가 낮다.
무엇이 잘못일까? 좀 더 수정이 필요해 보인다.



![ezgif com-gif-maker (1)](https://user-images.githubusercontent.com/92212636/160977548-6d8e25e2-e921-46a6-921f-ad836cff06c8.gif)


### 2022.04.09
클리어 시간을 측정하기 위해 타이머를 구현했다.

![타이머 구현](https://user-images.githubusercontent.com/92212636/163380310-2c0de61a-1989-492f-8ab2-450dcfb179d6.gif)




