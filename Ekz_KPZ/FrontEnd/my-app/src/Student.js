import React,{Component} from 'react';
import {Table} from 'react-bootstrap';
import {Button,ButtonToolbar} from 'react-bootstrap';
export class Student extends Component{

    constructor(props)
    {
        super(props);
        this.state={studentsTasks:[], addModalShow:false, editModalShow:false}
    }

    refreshList()
    {
        fetch('https://localhost:7241/api/v1/Student')
        .then(responce=>responce.json())
        .then(data=>{
                this.setState({studentsTasks:data});
                console.log(data);
            });
    }

    componentDidMount()
    {
        this.refreshList();
    }

    componentDidUpdate()
    {
        this.refreshList();
    }

    render(){
        const {studentsTasks}=this.state;



        return(
            <div>
                These are Students.
                <br></br>
                <div>
                <Table className="mt-4" striped bordered hover size="sm">
                    <thead>
                   
                        <tr>
                            <th>Student Name</th>
                            
                            <th>Options</th>
                        </tr>
                    </thead>
                    <tbody>
                        {studentsTasks.map(st=>
                            <tr key = {st.id}>
                                    <td>{st.firstName} {st.lastName}</td>
                                    
                                
                                    <td>
                                        <Button className="mr-2" variant = "info">Edit</Button>
                                        <Button>Delete</Button>
                                    </td>
                            </tr>)}
                    </tbody>
                 </Table>

                 <Button>
                   Add Student
                </Button>

                 </div>

            </div>
        )
    }
}