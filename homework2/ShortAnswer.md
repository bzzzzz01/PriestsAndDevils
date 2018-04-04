##### 游戏对象运动的本质是什么？
对象Transform中Position, Rotation, Scale变量的改变
##### 请用三种方法以上方法，实现物体的抛物线运动。
```
    public float xSpeed = 1, ySpeed = 1;
    Vector3 Vx, Vy;
    void Start()
    {
        Vector3 Vx = Vector3.right * xSpeed;
        Vector3 Vy = Vector3.zero;
    }
    void Update () {
        Vy += Vector3.down * ySpeed * Time.deltaTime;
        this.transform.position += (Vx + Vy) * Time.deltaTime;
    }
```
```
    void Update () {
        Vy += Vector3.down * ySpeed * Time.deltaTime;
        this.transform.Translate(Vx.x * Time.deltaTime, Space.World);
        this.transform.Translate(Vy.y * Time.deltaTime, Space.World);
    }
```
```
    void Update () {
        Vy += Vector3.down * ySpeed * Time.deltaTime;
        Vector3 step = (Vx + Vy) * Time.deltaTime;
		    this.transform.position = Vector3.MoveTowards(this.transform.position, target.position, step);
    }
```
