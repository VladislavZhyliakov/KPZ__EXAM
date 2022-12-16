import React,{Component} from 'react';
import {Table} from 'react-bootstrap';
import {Button,ButtonToolbar} from 'react-bootstrap';

import { AddStudentModal } from './AddStudentModal';


export class Home extends Component{

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

        var summaryGrade = 0;


        return(
            <div>
                These are Students and their University Tasks.
                <br></br>
                <div>
                <Table className="mt-4" striped bordered hover size="sm">
                    <thead>
                   
                        <tr>
                            <th>Student Name</th>
                            
                            <th>Task</th>
                        </tr>
                    </thead>
                    <tbody>
                        {studentsTasks.map(st=>
                            <tr key = {st.id}>
                                    <td>{st.firstName} {st.lastName}</td>
                                    {st.uniTasks.map( ut =>
                                    <td key = {ut.id}>{ut.description} | Grade: {ut.grade} | Priority: {ut.priority} | Date: {ut.taskDate}</td>
                                    )}
                                    <td>
                                        SummaryGrade :{summaryGrade}
                                    </td>
                                    <td>
                                        <Button className="mr-2" variant = "info">Edit</Button>
                                        <Button>Delete</Button>
                                    </td>
                            </tr>)}
                    </tbody>
                 </Table>

                 <Button>
                   Add Task
                </Button>

                 </div>

            </div>
        )
    }
}