0405
<br>

## 오브젝트 transform 설정

<br>
1. 오브젝트 위치 설정
`gameObject.transform.position = new Vector3(10,10,10);`

2. 오브젝트 회전시키기
`gameObject.transform.Rotate(Vector3.up,45); (축_방향의 기준, 각도)`

3. 오브젝트 이동시키기
`gameObject.transform.Translate(Vector3.forward*0.5f);`
 이때 로컬축 기준이 디폴트이고 , 월드축 기준으로 하려면 `Space.World` 옵션 추가
 Vector3.forward x 0.5f = 방향 x 힘

4. 오브젝트 크기 설정
`transform.localScale = new Vector3(2,2,2);`
`ransform.localScale = transform.localScale*1.1f;`
 아래의 코드를 Update 이벤트함수에 적용시키면 계속해서 오브젝트의 크기가 커진다.

>참고로 벡터의 개념은 숫자들의 좌표라고 이해했고 이 좌표는 방향이 될 수도 있고 위치의 개념이 될 수도 있다. <br>
그리고 `Vector3.forward`, `Vector3.up` 등의 개념은 이미 많이 쓰이는 벡터 좌표를 일반화 시켜놓은 것이다.
Vector3.forward=new Vector3(0,0,1)

<br>

- 키 눌렀을 때에만 실행시키기
`if(input.GetKeyDown(KeyCode.Space)){}` 
키 눌렀을때 true값이 되게 한다.
`GetKey`로 변경하면 누르고 있는 동안 계속 true값 반환



<br>

- 멤버변수

`public GameObject target;` public으로 전역변수를 설정하게 되면 unity inspector 창에서 그 값을 직접 지정해줄 수 있다.
