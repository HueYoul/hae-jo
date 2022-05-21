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


#### 2022.04.09

별을 다 먹었을때 클리어는 구현했지만

별을 먹다가 죽었을때 별을 초기화가 안되는 문제점이 있다.

![스타 초기화 문제](https://user-images.githubusercontent.com/92212636/164236632-3a0f8973-56ef-4062-9cfb-117010b32b66.gif)

![클리어 구현](https://user-images.githubusercontent.com/92212636/164236645-596b6f1a-b815-4e7e-898f-5244af25f245.gif)



#### 2022.04.20
서버에 타이머와 더블점프, 함정 등 특수효과를 구현했다. 

근데 두명의 시간이 다르게 측정되는 문제점이 있다.

![0420](https://user-images.githubusercontent.com/92212636/164236403-7168a622-53fe-4f5c-aaf3-fe499280eca4.gif)

#### 2022.05.05
오늘은 타이머를 일부분 손보고 스테이지 변경을 구현하였다.

![0505](https://user-images.githubusercontent.com/92212636/166886256-c5fd0d69-e832-4524-8e3c-c3e9aa3c2222.gif)


별을 하나 먹으면 타이머가 시작된다.

![0505(1)](https://user-images.githubusercontent.com/92212636/166886283-1c842d85-ac6b-4fe3-8ecb-8edd255f0476.gif)

스테이지 내의 별을 다 먹으면 다음 스테이지로 넘어간다.

좌측상단에 현재 몇 스테이지인지 알려주는 텍스트를 표시한다.


#### 2022.05.14
별을 다 먹었을 때 바로 다음스이지로 넘어가는 것이 원래의 방식이었다.

이 방식에서 별을 모두 획득 시 무지개 색의 별을 먹으면 다음 스테이지로 이동하는 방식으로 바꿨다.
(무지개 색 별 먹고 넘어가는 영상)


#### 2022.05.15
스테이지 1을 구현했다.
튜토리얼 느낌으로 구현을 해서 특수발판과 함정은 존재하지 않는다.

![12](https://user-images.githubusercontent.com/92212636/169641021-02d60dac-7a89-4c5c-aa77-8b2ed61b70f2.png)


#### 2022.05.21
스테이지 2를 구현했다.
본격적으로 특수발판과 함정을 이용하여 구현했다.

![123](https://user-images.githubusercontent.com/92212636/169641025-273e2814-8182-4d5a-8b85-3eaf3e13df08.PNG)



